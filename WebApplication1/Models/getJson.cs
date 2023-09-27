namespace WebApplication1.Models
{
    public class getJson
    {
        public string JSONString { get; set; }
        
}
    public class root
    {
        public List<form> forms { get; set; }
    }
    public class form
    {
public string type { get; set; }
        public string label { get; set; }
        public string[] options { get; set; }
    }
}
