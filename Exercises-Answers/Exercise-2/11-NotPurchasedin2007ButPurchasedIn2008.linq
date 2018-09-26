<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Not purchased in 2007
var npc2007 =
	Customers.Except(Orders.Where (o => o.Date.Year==2007).Select (o => o.Customer).Distinct());

// npc2007.Dump();

// Purchased in 2008
var p2008 = 
	from o in Orders
	join c in npc2007 on o.CustomerID equals c.ID
	where o.Date.Year==2008
	select o.Customer.Name;
	
p2008.Dump();	