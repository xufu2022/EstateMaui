# EstateMaui

    public class UnitTest1
    {    
        private HttpClient _client;
        public UnitTest1()
        {
            _client = new HttpClient();
        }
        [Fact]
        public async Task Test1()
        {
            var requestXml = """
<?xml version="1.0" encoding="utf-8"?>
<soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">
  <soap:Body>
    <HelloWorld xmlns="http://tempuri.org/">
      <id>1</id>
      <key>f1</key>
      <updateId>1</updateId>
    </HelloWorld>
  </soap:Body>
</soap:Envelope>
""";

            var content = new StringContent(requestXml, Encoding.UTF8, "text/xml");

            var response = await _client.PostAsync("http://localhost:4571/WebService1.asmx", content);

            response.EnsureSuccessStatusCode(); // this will throw an exception if the status code does not indicate success

            var responseString = await response.Content.ReadAsStringAsync();

            Assert.True(responseString.Contains("Hello World")); // this is a very basic check, you would typically want more specific 
        }
    }
