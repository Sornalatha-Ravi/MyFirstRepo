namespace TestApi.Services
{
    public interface IHostingEnvironment
    {
        string ContentRootPath { get; set; }
    }
    public class HostingEnvironment : IHostingEnvironment
    {
        public HostingEnvironment()
        {

        }
        public string ContentRootPath
        {
            get { return   "E:\\Test" ; }
            set { }
           
        }

    }
}
