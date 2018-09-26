<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Count the number of times the Hat ordered.
var res = 
	(from oi in OrderItems
	where oi.Product.Description == "hat"
	select oi).Count();

res.Dump();