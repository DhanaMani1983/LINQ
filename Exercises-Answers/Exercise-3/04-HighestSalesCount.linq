<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Highest Sales Count State

var res = 
	(from o in Orders
	where o.Customer != null
	group o by 	o.Customer.City.State.StateName
				 into sales
	select new {StateName=sales.Key,
				NoOfSales=sales.Count()}).Dump()
	.OrderByDescending (r => r.NoOfSales).First().StateName;

res.Dump();	