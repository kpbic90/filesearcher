using System;
using System.Threading;
using System.IO;

namespace FileSearcher
{
    public class FileSearchManager
    {
        #region Variables
        public delegate void FileEvent(string file);
        public event FileEvent OnFileFounded;
        public event FileEvent OnNextFile;
        public event EventHandler OnFinish = delegate { };

        private Thread thread;
        private static EventWaitHandle waitHandle = new ManualResetEvent(initialState: true);
        private bool isPaused = false;
        private bool isStopped = false;
        #endregion

        public FileSearchManager()
        { }

        #region Methods
        /// <summary>
        /// Функция начала поиска
        /// </summary>
        /// <param name="_path">Начальный путь поиска</param>
        /// <param name="_template">Шаблон файла</param>
        /// <param name="_symbols">Символы в имени файла для поиска</param>
        public void StartSearch(string _path, string _template, string _symbols)
        {
            Stop();
            isPaused = false;
            isStopped = false;
            waitHandle.Set();          

            thread = new Thread(() => Search(_path, _template, _symbols));
            thread.Start();
        }

        /// <summary>
        /// Функция паузы/продолжения
        /// </summary>
        public void PauseResume()
        {
            if (!isPaused)
            {
                waitHandle.Reset();
            }
            else
            {
                waitHandle.Set();
            }
            isPaused = !isPaused;
        }

        /// <summary>
        /// Функция остановки работы
        /// </summary>
        public void Stop()
        {
            if (thread != null && thread.IsAlive)
                thread.Abort();

            isStopped = true;
        }

        /// <summary>
        /// Функция поиска
        /// </summary>
        /// <param name="_path">Путь к файлам</param>
        /// <param name="_template">Шаблон файла</param>
        /// <param name="_symbols">Символы в имени</param>
        private void Search(string _path, string _template, string _symbols)
        {
            SearchDirectory(_path, _template, _symbols);
            OnFinish(this, EventArgs.Empty);
        }

        /// <summary>
        /// Функция поиска по директории
        /// </summary>
        /// <param name="_path">Путь к директории</param>
        /// <param name="_template">Шаблон имени файла</param>
        /// <param name="_symbols">Символы в файле</param>
        private void SearchDirectory(string _path, string _template, string _symbols)
        {
            DirectoryInfo di = new DirectoryInfo(_path);

            // Ищем среди подпапок
            foreach (DirectoryInfo dis in di.GetDirectories())
            {
                if (isStopped)
                    return;

                SearchDirectory(dis.FullName, _template, _symbols);
            }

            // Ищем по текущей папке
            foreach (FileInfo file in di.GetFiles(_template, SearchOption.TopDirectoryOnly))
            {
                if (isStopped)
                    return;

                OnNextFile(file.FullName);
                if(file.Name.Contains(_symbols))
                {
                    OnFileFounded(file.FullName);
                }
                waitHandle.WaitOne();
            }            
        }
        #endregion
    }
}
