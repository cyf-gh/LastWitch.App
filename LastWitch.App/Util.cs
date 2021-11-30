using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastWitch.App {
    public partial class Util : Form {
        public Util()
        {
            InitializeComponent();
        }

        private void u_btn_getSpotModelJson_Click( Object sender, EventArgs e )
        {
            Model.SpotModel spotModel = new Model.SpotModel();
            var id = new Model.SpotModel.IngredientDistributionModel();
            spotModel.IngredientDistributions.Add( id );
            id.CPs.Add( new Model.SpotModel.IngredientDistributionModel.CountProp {Count = 10, Prop = 100 });
            u_tb_output.Text = JsonConvert.SerializeObject( spotModel );
        }

        private void btn_getIngredientInfoJson_Click( Object sender, EventArgs e )
        {
            u_tb_output.Text = Model.GameDataModel.GetIngredInfosJson();
        }
    }
}
