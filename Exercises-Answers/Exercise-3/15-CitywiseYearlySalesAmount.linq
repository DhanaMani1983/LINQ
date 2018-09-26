<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Citywise Yearly Sales Amount.
var res =
	from o in Orders
	group o by new { o.Customer.City.CityName, o.Date.Year } into sales
	select new { City=sales.Key.CityName,
				 Year=sales.Key.Year,
				 TotalSales=sales.Sum (s => s.TotalSalesAmount)} into salesanalysis
	orderby salesanalysis.City, salesanalysis.Year
	select salesanalysis;
				 
res.Dump();				 