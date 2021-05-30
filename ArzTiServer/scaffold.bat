
dotnet ef dbcontext scaffold "Username=postgres;Password=postgres;Server=localhost;Port=5432;Database=apoti;Integrated Security=true;Pooling=true;" Npgsql.EntityFrameworkCore.PostgreSQL -o ModelDb