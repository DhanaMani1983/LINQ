<Query Kind="Statements">
  <Connection>
    <ID>dc6546dd-0ed0-4a47-89d8-c787dc4e85d3</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>LinqPractice</Database>
  </Connection>
</Query>

int[] numbers = { 10, 90, 80, 70, 60 };

numbers.Select (n => n/10).Dump("First Digits").Sum ().Dump();