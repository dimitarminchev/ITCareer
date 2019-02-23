# Пакети и външни библиотеки

## JSON.NET
https://www.newtonsoft.com/json
http://www.json.org/
http://json2csharp.com/

### Serialize
```
string json = JsonConvert.SerializeObject(new Product()
{
	Id = 1,
	Name = "Apple",
	Price = 1.2M,
	Stock = 10,
	Expiry = new DateTime(2019,12,31)
});
```

### Deserialize
```
var client = new WebClient();
var text = client.DownloadString(new Uri("http://api.icndb.com/jokes/random"));
var json = JsonConvert.DeserializeObject<RootObject>(text);
```

## Tesseract
```
string dir = Environment.CurrentDirectory;
string file = String.Concat(dir, "\\test.png");
var engine = new TesseractEngine(@"tessdata", "eng");
var pic = Pix.LoadFromFile(file);
var page = engine.Process(pic);
string text = page.GetText();
```