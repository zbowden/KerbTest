using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using System.Data;




namespace KerbTest
{
    
    public partial class _Default : Page
    {
        [OperationBehavior(Impersonation = ImpersonationOption.Allowed)]
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name + " by way of: " +  System.Security.Principal.WindowsIdentity.GetCurrent().AuthenticationType.ToString();

            try
            {
                DataView dv1 = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
                String sqlserver_username = (string)dv1.Table.Rows[0][0];
                Label2.Text = sqlserver_username;
            }

            catch (System.Exception ex)
            {
                Label2.Text = ex.ToString();
                
            }

            try
            {
                DataView dv2 = (DataView)SqlDataSource2.Select(DataSourceSelectArguments.Empty);
                String gp_username = (string)dv2.Table.Rows[0][0];
                Label3.Text = gp_username;
            }

            catch (System.Exception ex)
            {
                Label3.Text = ex.ToString();

            }



            /*
             * // SQL Server Kerberos Test
             * 
             *      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DevSAWConnectionString %>" SelectCommand="SELECT SYSTEM_USER"></asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Column1" HeaderText="SQL Server User" ReadOnly="True" SortExpression="Column1" />
        </Columns>
    </asp:GridView>
    
             * 
             *     <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PGConnection %>" SelectCommand="SELECT current_user as Column1" ProviderName="System.Data.Odbc"></asp:SqlDataSource>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
        <Columns>
            <asp:BoundField DataField="Column1" HeaderText="Greenplum User" ReadOnly="True" SortExpression="Column1" />
        </Columns>
    </asp:GridView>
             * 
             */

        }
    }
}