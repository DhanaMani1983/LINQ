<Query Kind="Statements">
  <Connection>
    <ID>385b039f-f56e-4b1a-a5c5-7cc2043560fa</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

// Customer with name contains "ar" and email contains "r?.me" where ? may be any character.

Customers.Where (c => c.Name.Contains("ar")).ToList().Where (c => Regex.IsMatch(c.EmailId, "r..me")).Dump();