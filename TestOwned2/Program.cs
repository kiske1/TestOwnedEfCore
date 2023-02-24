using Microsoft.EntityFrameworkCore;
using TestOwned2;
using TestOwned2.Entities;

var optionsBuilder = new DbContextOptionsBuilder<TestDbContext>();
optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OwnedVOTest3;ConnectRetryCount=0");

var context = new TestDbContext(optionsBuilder.Options);

try
{
    Console.WriteLine("VALUES BEFORE");
    foreach (var parent in context.Parents.Include(p => p.Values))
    {
        Console.WriteLine($"VALUE FOR PARENT {parent.Id.ToString()}: {parent.Values.First()?.Field1?? "- NOT FOUND -"}");
    }
}
catch(Exception ex){}

context.Database.EnsureDeleted();
    context.Database.Migrate();

    var values = new List<ValueObject>() { new ValueObject("XXX", "YYY") };
    var parent1 = new Parent(Guid.NewGuid(), "TEST1", values);
    var parent2 = new Parent(Guid.NewGuid(), "TEST2", values);

context.Parents.Add(parent1);
context.Parents.Add(parent2);

context.SaveChanges();
Console.WriteLine("VALUES AFTER");
foreach (var parent in context.Parents.Include(p => p.Values))
{
    Console.WriteLine($"VALUE FOR PARENT {parent.Id.ToString()}: {parent.Values.First()?.Field1 ?? "- NOT FOUND -"}");
}