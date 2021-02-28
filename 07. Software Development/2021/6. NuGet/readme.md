# JSON
More information about JSONL
https://www.json.org/json-bg.html

## Chuck Norris Jokes API
https://api.chucknorris.io/ or 
https://api.chucknorris.io/jokes/random
```
{"categories":[],"created_at":"2020-01-05 13:42:23.880601","icon_url":"https://assets.chucknorris.host/img/avatar/chuck-norris.png","id":"R55uzYlySNGawd5gdctDvw","updated_at":"2020-01-05 13:42:23.880601","url":"https://api.chucknorris.io/jokes/R55uzYlySNGawd5gdctDvw","value":"Four score and seven years ago... Chuck Norris drank a barrel of mead and roundhouse kicked the shit outta some mutton chop-wearing assholes."}
```

## Additional Resources
- JSON Online Viewer: http://jsonviewer.stack.hu/
- Convert Json to C# Classes Online: https://json2csharp.com/

## NewtonSoft.Json 12.0.3
https://www.newtonsoft.com/json

### Serialize
```
Product product = new Product();
product.Name = "Apple";
product.Expiry = new DateTime(2008, 12, 28);
product.Sizes = new string[] { "Small" };

string json = JsonConvert.SerializeObject(product);
// {
//   "Name": "Apple",
//   "Expiry": "2008-12-28T00:00:00",
//   "Sizes": [
//     "Small"
//   ]
// }
```

### Deserialize
```
string json = @"{
  'Name': 'Bad Boys',
  'ReleaseDate': '1995-4-7T00:00:00',
  'Genres': [
    'Action',
    'Comedy'
  ]
}";

Movie m = JsonConvert.DeserializeObject<Movie>(json);

string name = m.Name;
// Bad Boys
```