using Newtonsoft.Json;
using RulesEngine.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole;

class Programs
{
    static void Main(string[] args)
    {
        var rules = JsonConvert.DeserializeObject<RuleEngineWorkFlowModel>(File.ReadAllText(@"C:\Users\bhchag\source\repos\TestRepository\TestConsole\TestConsole\TestJson.json"));
        Test test = new Test()
        {
            oneElement = "dd",
            threeElement = "ff",
            fourElement = "fff",
            twoElement = "dd"
        };
        List<Test> list = new List<Test>();
        list.Add(test);
        var tt = list.Where(x => string.IsNullOrEmpty(x.fourElement) || string.IsNullOrEmpty(x.threeElement) || string.IsNullOrEmpty(x.oneElement) || string.IsNullOrEmpty(x.twoElement)).ToList().Count();


        //x.Where(x => string.IsNullOrEmpty(x.fourElement) || string.IsNullOrEmpty(x.threeElement) || string.IsNullOrEmpty(x.oneElement) || string.IsNullOrEmpty(x.twoElement)).ToList();
    }

}

public class Test
{
    public string oneElement { get; set; }
    public string twoElement { get; set; }
    public string threeElement { get; set; }
    public string fourElement { get; set; }
}
