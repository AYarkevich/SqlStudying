using System;
using Common;
using DBConnectionCore;


var msCon = new MsSqlConnectionBase();
var pgCon = new PostgresConnectionBase();

Console.WriteLine(msCon.GetConnectionState());
Console.WriteLine(pgCon.GetConnectionState());