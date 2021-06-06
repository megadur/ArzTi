SET CONN="Username=postgres;Password=postgres;Server=localhost;Port=5432;Database=ArzDb;Integrated Security=true;Pooling=true;"
SET CONN="Username=dbuser;Password=pass1234;Server=opipc;Port=5432;Database=ArzDb;Integrated Security=true;Pooling=true;"

dotnet ef dbcontext scaffold  %CONN% Npgsql.EntityFrameworkCore.PostgreSQL -o Domain\Model -f