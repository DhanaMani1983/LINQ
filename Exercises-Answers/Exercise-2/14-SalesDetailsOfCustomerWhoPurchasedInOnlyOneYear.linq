<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Customers who purchase in only one year.
var cone = 
	from o in Orders
	where o.Customer != null
	group o.Date.Year by o.CustomerID into ids
	where ids.Count ()==1
	select ids.Key;
	
// cone.Dump();	
var res =
	from o in Orders
	where cone.Contains(o.CustomerID)
	group o by o.Customer into orders
	select new {CustomerName = orders.Key.Name, NoOfBills=orders.Count (),
					TotalSales=orders.Sum (o => o.TotalSalesAmount),
					AverageSales=orders.Average (o => o.TotalSalesAmount)};

res.Dump();