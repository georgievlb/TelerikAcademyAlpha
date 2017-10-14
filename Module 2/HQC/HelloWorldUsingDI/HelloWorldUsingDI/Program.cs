namespace HelloWorldUsingDI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Poor man's DI - create the writer and pass it to the salutation. No container is used. 
            //IMessageWriter writer = new ConsoleMessageWriter(); //create concrete writer(Console)
            IMessageWriter writer = new FileMessageWriter();      //create concrete writer(File)
            //IMessageWriter writer = new DataBaseWriter();         //create concrete writer(DataBase)
            var salutation = new Salutation(writer);            //Inject it as dependency
            salutation.Exclaim();                               //Call the action
        }
    }
}
