<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Identify the Cities in which no sales has been made so far.

Cities.Except(Orders
		.Select (o => o.Customer.City)
		.Distinct()).Dump();