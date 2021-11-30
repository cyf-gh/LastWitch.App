using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LastWitch.App {
    namespace Model {
        public class GameDataModel {
            static public IngredientInfoModel GetIngredInfoNameById( int id )
            {
                return IngredInfos.Find( i => { return id == i.Id; } );
            }
            static public List<IngredientInfoModel> LoadIngredInfos( string path )
            {
                IngredInfos = Excel.DeserializeList<IngredientInfoModel>( path, true );
                return IngredInfos;
            }
            static public List<IngredientInfoModel> IngredInfos { get; set; } = new List<IngredientInfoModel>();
            static public string GetIngredInfosJson()
            {
                return JsonConvert.SerializeObject( IngredInfos );
            }
            static public List<SpotModel> SpotModels { get; set; } = new List<SpotModel>();
            /// <summary>
            /// 从Json文件载入Spot信息
            /// 调用完成后请不要忘记调用InitSpotModels进行初始化
            /// </summary>
            /// <param name="path"></param>
            /// <returns></returns>
            static public List<SpotModel> LoadSpotModels( string path )
            {
                var t = File.ReadAllText( path );
                SpotModels = JsonConvert.DeserializeObject<List<SpotModel>>( t );
                return SpotModels;
            }
            static public List<SpotModel> InitSpotModels( Control parent, ToolTip tt )
            {
                foreach ( var sm in SpotModels ) {
                    sm.CreateButton( parent, tt );
                }
                return SpotModels;
            }


            public static GameDataModel Data { get; set; }
            public static GameDataModel NewGame()
            {
                return new GameDataModel {
                    StartTime = DateTime.Now.Ticks,
                    Inventory = new InventoryModel()
                };
            }
            /// <summary>
            /// 新游戏开始时间
            /// </summary>
            public long StartTime { get; set; }
            /// <summary>
            /// 上一次保存时的时间
            /// </summary>
            public long LastSaveTime { get; set; }
            public GameDataModel( string path = "" )
            {
                if ( path == "" ) {
                    return;
                }
            }
            public InventoryModel Inventory { get; set; }
            public long PlayedTime() { return LastSaveTime - StartTime; }
            public static void Load( string path )
            {
                Data = new GameDataModel( path );
            }
            public void Save( string path )
            {
                Data.LastSaveTime = DateTime.Now.Ticks;
                var jstr = JsonConvert.SerializeObject( Data );
                File.WriteAllText( path, jstr );
            }
        }
        public class IngredientInfoModel {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Quality { get; set; }
            public int BaseScore { get; set; }
            public string Description { get; set; }
        }
        public class IngredientModel {
            public IngredientInfoModel Info { get; set; }
            public long PickTime { get; set; }
            public int Count { get; set; } = 0;
            public void Put( int amount = 1 )
            {
                Count += amount;
            }
            public void Take()
            {
                Count = Count - 1 <= 0 ? 0 : Count - 1;
            }
            public IngredientModel( IngredientInfoModel ingInfo, int Count, long Picktime = -1 )
            {
                this.Info = ingInfo;
                this.PickTime = PickTime == -1 ? DateTime.Now.Ticks : PickTime;
                this.Count = Count;
            }
        }
        public class InventoryModel {
            static public List<IngredientModel> Ingredients { get; set; } = new List<IngredientModel>();
            public InventoryModel()
            {
                for ( int i = 0; i < GameDataModel.IngredInfos.Count; i++ ) {
                    var ing = new IngredientModel( GameDataModel.IngredInfos[i], 0 );
                    Ingredients.Add( ing );
                }
            }
        }
        public class SpotModel {
            private static void EventSpotClick( Object sender, EventArgs e )
            {
                // TODO:
                return;
            }
            public void CreateButton( Control parent, ToolTip tt )
            {
                if ( Button != null ) {
                    return;
                }
                Button = new Button();
                Button.Location = Position;
                Button.Click += EventSpotClick;
                Button.Parent = parent;
                Button.Text = Name;
                tt.SetToolTip( Button, GenerateTooltipString() );
            }
            public SpotModel()
            {
                IngredientDistributions = new List<IngredientDistributionModel>();
            }
            public string GenerateTooltipString() { 
                string a = "";
                foreach ( var i in IngredientDistributions ) {
                    var IngInfo = GameDataModel.GetIngredInfoNameById( i.Id );
                    double lastProp = 0;
                    a += $"{IngInfo.Name}\n";
                    foreach ( var cp in i.CPs ) {
                        a += $"\t{cp.Count} - [{lastProp}% ~ {cp.Prop}%]\n";
                        lastProp = cp.Prop;
                    }
                }
                return a;

            }
            /// <summary>
            /// 每个Spot的食物采集概率
            /// </summary>
            public class IngredientDistributionModel {
                public class CountProp {
                    public int Count { get; set; }
                    public double Prop { get; set; }
                }
                public int Id { get; set; }
                public List<CountProp> CPs { get; set; } = new List<CountProp>();
            }
            public string Name { get; set; }
            public Point Position { get; set; }
            public Button Button { get; set; }
            public List<IngredientDistributionModel> IngredientDistributions { get; set; }
        }

    }
}
