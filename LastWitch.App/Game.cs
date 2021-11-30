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
    public partial class Game : Form {
        public Game()
        {
            InitializeComponent();
        }
        ToolTip toolTip = new ToolTip();
        private void Game_Load( Object sender, EventArgs e )
        {
            if ( Global.Debug ) {
                Util u = new Util();
                u.Show();
            }
            Model.GameDataModel.LoadIngredInfos( "./IngredientInfos.xlsx" );

            Model.GameDataModel.LoadSpotModels( "./spots.json" );
            Model.GameDataModel.InitSpotModels( tp_World, toolTip );
            // 载入地图相关

        }

        private void btn_Exit_Click( Object sender, EventArgs e )
        {
            Application.Exit();
        }

        private void tp_World_Click( Object sender, EventArgs e )
        {

        }

        private void btn_NewGame_Click( Object sender, EventArgs e )
        {
            tabControl.SelectedTab = tp_World;
        }

        private void Game_KeyPress( Object sender, KeyPressEventArgs e )
        {

        }

        private void Game_KeyDown( Object sender, KeyEventArgs e )
        {

        }

        private void uTILToolStripMenuItem_Click( Object sender, EventArgs e )
        {
            Util u = new Util();
            u.Show();
        }
    }
}
