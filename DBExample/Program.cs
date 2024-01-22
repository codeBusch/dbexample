

using DBExample.Repositories;
using Newtonsoft.Json;

MyDbContext db = new();
db.Users.Add(new DBExample.Entities.User { FirstName = "Bahri", LastName = "Baş", IdentificationNumber = "1231241", IsActive = true, Password = "1234", UserName = "bahri1234" });
//db.Jobbers.Add(new DBExample.Entities.Jobber {Plate="test",WorkArea="test",User})
db.SaveChanges();
var user = db.Users.FirstOrDefault();
Console.WriteLine(JsonConvert.SerializeObject(user));
Console.ReadLine();