<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Highest Sales Amount City

var res = 
	(from o in Orders
	where o.Customer != null
	group o by 	o.Customer.City.CityName
				 into sales
	select new {CityName=sales.Key,
				TotalSales=sales.Sum (s => s.TotalSalesAmount)}).Dump()
	.OrderByDescending (r => r.TotalSales).First().CityName;

res.Dump();	