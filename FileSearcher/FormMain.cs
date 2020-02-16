using System;
using System.Linq;
using System.Windows.Forms;

namespace FileSearcher
{
    public partial class FormMain : Form
    {
        #region Variables
        private FileSearchManager manager;
        private DateTime startTime;                             // Время начала поиска
        private int counter = 0;                                // Количество обработанных файлов
        #endregion
        public FormMain()
        {
            InitializeComponent();

            manager = new FileSearchManager();
            manager.OnFileFounded += Manager_OnFileFounded;
            manager.OnNextFile += Manager_OnNextFile;
            manager.OnFinish += Manager_OnFinish;
        }

        #region Events
        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                textBoxPath.Text = Properties.Settings.Default.Path;
                textBoxFileTemplate.Text = Properties.Settings.Default.Template;
                textBoxSymbols.Text = Properties.Settings.Default.Symbols;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Path = textBoxPath.Text;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxFileTemplate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Template = textBoxFileTemplate.Text;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSymbols_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Symbols = textBoxSymbols.Text;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelectPath_Click(object sender, EventArgs e)
        {
            try 
            { 
                using(FolderBrowserDialog f = new FolderBrowserDialog())
                {
                    f.SelectedPath = textBoxPath.Text;
                    if(f.ShowDialog() == DialogResult.OK)
                    {
                        textBoxPath.Text = f.SelectedPath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SelectPath: " + ex.Message);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            buttonSearch.Enabled = false;
            textBoxPath.Enabled = false;
            buttonSelectPath.Enabled = false;
            textBoxFileTemplate.Enabled = false;
            textBoxSymbols.Enabled = false;
            buttonStop.Enabled = true;
            buttonStop.Text = "Остановить";
            try
            {
                startTime = DateTime.Now;
                counter = 0;
                treeViewData.Nodes.Clear();
                manager.StartSearch(textBoxPath.Text, textBoxFileTemplate.Text, textBoxSymbols.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search: " + ex.Message);
            }
        }

        private void Manager_OnFinish(object sender, EventArgs e)
        {
            try
            {
                Finish();
            }
            catch (Exception ex)
            {
                MessageBox.Show("OnFinish: " + ex.Message);
            }
        }

        private void Manager_OnNextFile(string file)
        {
            try
            {
                counter++;
                AppendLabelCurrentData(string.Format("{1} files\n{2:HH:mm:ss}\n{0}", file, counter, DateTime.Now - startTime));
            }
            catch (Exception ex)
            {
                MessageBox.Show("OnNextFile: " + ex.Message);
            }
        }

        private void Manager_OnFileFounded(string file)
        {
            try
            {
                AppendTree(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show("OnFileFounded: " + ex.Message);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            try
            {
                manager.PauseResume();

                buttonSearch.Enabled = !buttonSearch.Enabled;
                textBoxPath.Enabled = !textBoxPath.Enabled;
                buttonSelectPath.Enabled = !buttonSelectPath.Enabled;
                textBoxFileTemplate.Enabled = !textBoxFileTemplate.Enabled;
                textBoxSymbols.Enabled = !textBoxSymbols.Enabled;
                buttonStop.Text = buttonStop.Text == "Остановить" ? "Продолжить" : "Остановить";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stop: " + ex.Message);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if(manager != null)
                    manager.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Closing: " + ex.Message);
            }
        }
        #endregion

        #region Methods
        private void AppendLabelCurrentData(string value)
        {
            try
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action<string>(AppendLabelCurrentData), new object[] { value });
                    return;
                }

                labelCurrentData.Text = value;
            }
            catch { }
        }

        private void AppendTree(string value)
        {
            try
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action<string>(AppendTree), new object[] { value });
                    return;
                }

                AddNode(value, treeViewData.Nodes);
            }
            catch { }
        }

        /// <summary>
        /// Функция добавления элемента в дерево
        /// </summary>
        /// <param name="file">Имя файла</param>
        /// <param name="nodes">Набор элементов среди которых ищем родительский элемент для текущего</param>
        private void AddNode(string file, TreeNodeCollection nodes)
        {
            bool flag = false;
            string current_folder = file.Split('\\')[0];

            if (string.IsNullOrEmpty(current_folder))
                return;

            // Ищем родительский элемент
            foreach (TreeNode node in nodes)
            {
                if (node.Text == current_folder)
                {
                    flag = true;
                    // Если нашли, рекурсивно ищем среди дочерних
                    AddNode(file.Substring(current_folder.Length + 1, file.Length - current_folder.Length - 1), node.Nodes);
                    break;
                }
            }

            // Если родительский элемент не найден, добавляем новый элемент на текущий уровень
            if(!flag)
            {
                nodes.Add(current_folder);
                if(file.Contains('\\'))
                    AddNode(file.Substring(current_folder.Length + 1, file.Length - current_folder.Length - 1), nodes[nodes.Count - 1].Nodes);
            }
        }

        /// <summary>
        /// Функция завершения
        /// </summary>
        private void Finish()
        {
            if(InvokeRequired)
            {
                this.Invoke(new Action(Finish));
                return;
            }
            try
            {
                buttonSearch.Enabled = true;
                textBoxPath.Enabled = true;
                buttonSelectPath.Enabled = true;
                textBoxFileTemplate.Enabled = true;
                textBoxSymbols.Enabled = true;
                buttonStop.Enabled = false;
            }
            catch { }
        }
        #endregion
    }
}
