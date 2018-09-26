<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Customers who have not purchased in the year 2009

var cpur = 
	from o in Orders
	where o.Date.Year == 2009
	select new {o.CustomerID};

var missedCustomers =
	from c in Customers
	join cp in cpur on c.ID equals cp.CustomerID into cus
	from cp in cus.DefaultIfEmpty()
	where cp == null
	select c.Name;
	
missedCustomers.Dump();	
