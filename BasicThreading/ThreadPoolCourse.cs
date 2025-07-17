namespace AsenkronveMultithread
{
    class ThreadPoolCourse
    {
        public void ThreadPoolMethod()
        {
            ThreadPool.SetMaxThreads(4, 4);

            ThreadPool.QueueUserWorkItem(WorkerMethod, "Task 1");
            ThreadPool.QueueUserWorkItem(WorkerMethod, "Task 2");
            ThreadPool.QueueUserWorkItem(WorkerMethod, "Task 3");
            ThreadPool.QueueUserWorkItem(WorkerMethod, "Task 4");
            ThreadPool.QueueUserWorkItem(WorkerMethod, "Task 5");
            ThreadPool.QueueUserWorkItem(WorkerMethod, "Task 6");
            Console.Read();
    
        }
        void WorkerMethod(object state)
        {
            Console.WriteLine($" *** Thread Count : {ThreadPool.ThreadCount}");
            string name = (string)state;
            Console.WriteLine($"{name} işi başladı");
            Thread.Sleep(new Random().Next(1000, 5000));
            Console.WriteLine($"{name} işi tamamlandı");
        }
    }
}