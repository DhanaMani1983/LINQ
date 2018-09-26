<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Customer Purchased in 2008
var c2008 = 
	(from o in Orders
	where o.Date.Year == 2008 && o.CustomerID != null
	select o.CustomerID).Distinct();
	
// c2008.Dump();

// Purchased in 2009
var c2009 = 
	(from o in Orders
	where o.Date.Year == 2009 && o.CustomerID != null
	select o.CustomerID).Distinct();

// c2009.Dump();

var missing = c2008.Except(c2009);

(
	from mc in missing
	join c in Customers on mc equals c.ID
	select c.Name
).Dump();