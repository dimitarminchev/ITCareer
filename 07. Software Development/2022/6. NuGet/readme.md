# JSON
1. [JavaScript Object Notation](https://www.json.org/json-bg.html)
2. [Chuck Norris JSON Api](https://api.chucknorris.io/)
3. [JSON Online Viewer](http://jsonviewer.stack.hu/)
4. [Convert Json 2 Csharp](https://json2csharp.com/)
5. [Json.NET](https://www.newtonsoft.com/json)

## 1. Sample Chuck Norris Joke in JSON
```
{
	"categories" : [],
	"created_at" : "2020-01-05 13:42:30.730109",
	"icon_url" : "https://assets.chucknorris.host/img/avatar/chuck-norris.png",
	"id" : "s9wxJ1UlQkurZDKSsQSCXA","updated_at":"2020-01-05 13:42:30.730109",
	"url" : "https://api.chucknorris.io/jokes/s9wxJ1UlQkurZDKSsQSCXA",
	"value" : "Chuck Norris killed osama bin laden, he roundhoused the bullt through his skull!"
}
```
## 2. Sample JSON to C# Class
```
public class Root
{
    public List<object> categories { get; set; }
    public string created_at { get; set; }
    public string icon_url { get; set; }
    public string id { get; set; }
    public string updated_at { get; set; }
    public string url { get; set; }
    public string value { get; set; }
}
```

## 3. Deserialize JSON to Object
```
var obj = JsonConvert.DeserializeObject<Root>(joke);
```

## 4. Serialize Object to JSON
```
var json  = JsonConvert.SerializeObject(obj);
```