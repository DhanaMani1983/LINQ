<Query Kind="Statements">
  <Connection>
    <ID>dc6546dd-0ed0-4a47-89d8-c787dc4e85d3</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

string[] names = { "Tom", "Dick", "Harry" };
names.Where (n => n.Length >= 4).Dump();