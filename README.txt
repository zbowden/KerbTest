

To deploy to an IIS Server -- I recommend using the publish as a zip file method and deploying with the command line utility created.

That will deploy it and then you can modify the application pool and web application as follows:

	1. Create a new app pool and configure the web app to use it
	2. Run the app pool as NETWORK SERVICE with 32-bit applications enabled (v.4x framework, integrated mode)
	3. On the web app itself, enable Windows Authentication and ASP.NET Impersonation.
		a. Under Windows Authentication:
			i. Extended Protection should be Off and the checkbox next to "Enable Kernel-mode authentication" should be UNCHECKED.
			ii. The only Enabled Provider should be "Negotiate: Kerberos".
		b. ASP.NET Impersonation should be set to the identity to impersonate of "Authenticated user".

	4. In order for delegation to work, you will need to ensure that you have the appropriate SPN setup for your web service -- the service is HTTP and the address needs to be
		the same address in which you will access the KerbTest website. For instance, if my server name is WEBSERVER$ and I want to access it via webserver.company.com I need to:
			setspn -A HTTP/webserver.company.com webserver


Configuration:
	Once deployed, the configuration takes place within the web.config file. Specifically, all you need to change are the connection strings:

	1. SQL Server connection string -- just point to the name of your sql server:
	<add name="SQLConnectionString" connectionString="Data Source=sql_server_fqdn;Initial Catalog=master;Integrated Security=True"
      providerName="System.Data.SqlClient" />

	2. Postgres -- just point to the name of the DSN you created for testing the postgres connection (or you can configure a connection string):

    <add name="PGConnection" connectionString="DSN=MBTASP_DSN" providerName="System.Data.Odbc"/>
