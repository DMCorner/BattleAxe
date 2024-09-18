using BattleAxe;
using Microsoft.EntityFrameworkCore;

await using var db = new BattleAxe.UnitContext();

Console.WriteLine("Querying for Units");

//Read
    var results =
        from unit in await db.Units.ToListAsync()
        select unit;


List<Unit> LocalUnits = results.ToList();


    foreach (var s in results)
        {
            Console.WriteLine("Unit id: " + s.UnitId + " Unit Name: " + s.UnitName + " Unit Type: " + s.UnitType + " Unit Cost: " + s.UnitCost);
    //new Unit( UnitId = s.UnitId, UnitName = s.UnitName,UnitType = s.UnitType , UnitCost = s.UnitCost );
    Console.WriteLine(LocalUnits[1].UnitId + LocalUnits[1].UnitName);
        }

