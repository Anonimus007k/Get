private static string GET(string Url, string Data)
{
   System.Net.WebRequest req = System.Net.WebRequest.Create(Url + "?" + Data);
   System.Net.WebResponse resp = req.GetResponse();
   System.IO.Stream stream = resp.GetResponseStream();
   System.IO.StreamReader sr = new System.IO.StreamReader(stream);
   string Out = sr.ReadToEnd();
   sr.Close();
   return Out;
}
