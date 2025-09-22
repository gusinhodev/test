# test
VECONINTER TEST

🧱 Configuración de la base de datos
Este proyecto utiliza Entity Framework Core para manejar la base de datos mediante migraciones. No necesitas subir ni descargar archivos .mdf o .sqlite, ya que la estructura se genera automáticamente.

🔧 Requisitos
Tener instalado el SDK de .NET

Tener acceso a SQL Server (Express, LocalDB o instancia remota)

Tener configurada la cadena de conexión en appsettings.json

🚀 Crear la base de datos desde cero
Abre la terminal en la raíz del proyecto (donde está el .csproj)

Ejecuta el siguiente comando para aplicar las migraciones:
dotnet ef database update

-> Las migraciones se guardan en la carpeta Migrations/

