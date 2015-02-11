using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BF4HUDEditor
{
    public partial class BF4HUDE_Main : Form
    {
        public BF4HUDE_Main()
        {
            InitializeComponent();
        }

        private void HUDSize_trackBar_Scroll(object sender, EventArgs e)
        {
            HUDSize_textBox.Text = "" + HUDSize_trackBar.Value;
        }

        private void InvOpa_trackBar_Scroll(object sender, EventArgs e)
        {
            InvOpa_textBox.Text = "" + InvOpa_trackBar.Value;
        }

        private void StatusOpa_trackBar_Scroll(object sender, EventArgs e)
        {
            StatusOpa_textBox.Text = "" + StatusOpa_trackBar.Value;
        }

        private void OccuOpa_trackBar_Scroll(object sender, EventArgs e)
        {
            OccuOpa_textBox.Text = "" + OccuOpa_trackBar.Value;
        }

        private void KillLogOpa_trackBar_Scroll(object sender, EventArgs e)
        {
            KillLogOpa_textBox.Text = "" + KillLogOpa_trackBar.Value;
        }

        private void MiscOpa_trackBar_Scroll(object sender, EventArgs e)
        {
            MiscOpa_textBox.Text = "" + MiscOpa_trackBar.Value;
        }

        private void MapSize_trackBar_Scroll(object sender, EventArgs e)
        {
            MapSize_textBox.Text = "" + MapSize_trackBar.Value;
        }

        private void MapBackOpa_trackBar_Scroll(object sender, EventArgs e)
        {
            MapBackOpa_textBox.Text = "" + MapBackOpa_trackBar.Value;
        }

        private void MapIconOpa_trackBar_Scroll(object sender, EventArgs e)
        {
            MapIconOpa_textBox.Text = "" + MapIconOpa_trackBar.Value;
        }

        private void MapIconSize_trackBar_Scroll(object sender, EventArgs e)
        {
            MapIconSize_textBox.Text = "" + MapIconSize_trackBar.Value;
        }

        private void HitSize_trackBar_Scroll(object sender, EventArgs e)
        {
            HitSize_textBox.Text = "" + HitSize_trackBar.Value;
        }

        private void HitOpa_trackBar_Scroll(object sender, EventArgs e)
        {
            HitOpa_textBox.Text = "" + HitOpa_trackBar.Value;
        }

        private void CommonSize_trackBar_Scroll(object sender, EventArgs e)
        {
            CommonSize_textBox.Text = "" + CommonSize_trackBar.Value;
        }

        private void CommonScale_trackBar_Scroll(object sender, EventArgs e)
        {
            CommonScale_textBox.Text = "" + CommonScale_trackBar.Value;
        }

        private void CommonIconOpa_trackBar_Scroll(object sender, EventArgs e)
        {
            CommonIconOpa_textBox.Text = "" + CommonIconOpa_trackBar.Value;
        }

        private void CommonObjOpaZoom_trackBar_Scroll(object sender, EventArgs e)
        {
            CommonObjOpaZoom_textBox.Text = "" + CommonObjOpaZoom_trackBar.Value;
        }

        private void CommonInterOpaZoom_trackBar_Scroll(object sender, EventArgs e)
        {
            CommonInterOpaZoom_textBox.Text = "" + CommonInterOpaZoom_trackBar.Value;
        }

        private void CommonPickupOpaZoom_trackBar_Scroll(object sender, EventArgs e)
        {
            CommonPickupOpaZoom_textBox.Text = "" + CommonPickupOpaZoom_trackBar.Value;
        }

        private void CommonGadgetOpaZoom_trackBar_Scroll(object sender, EventArgs e)
        {
            CommonGadgetOpaZoom_textBox.Text = "" + CommonGadgetOpaZoom_trackBar.Value;
        }

        private void EnemySize_trackBar_Scroll(object sender, EventArgs e)
        {
            EnemySize_textBox.Text = "" + EnemySize_trackBar.Value;
        }

        private void EnemyScale_trackBar_Scroll(object sender, EventArgs e)
        {
            EnemyScale_textBox.Text = "" + EnemyScale_trackBar.Value;
        }

        private void EnemyIconOpa_trackBar_Scroll(object sender, EventArgs e)
        {
            EnemyInfoOpa_textBox.Text = "" + EnemyInfoOpa_trackBar.Value;
        }

        private void EnemyIconOpaZoom_trackBar_Scroll(object sender, EventArgs e)
        {
            EnemyIconOpaZoom_textBox.Text = "" + EnemyIconOpaZoom_trackBar.Value;
        }

        private void EnemyHealthOpa_trackBar_Scroll(object sender, EventArgs e)
        {
            EnemyHealthOpa_textBox.Text = "" + EnemyHealthOpa_trackBar.Value;
        }

        private void EnemyHealthOpaZoom_trackBar_Scroll(object sender, EventArgs e)
        {
            EnemyHealthOpaZoom_textBox.Text = "" + EnemyHealthOpaZoom_trackBar.Value;
        }

        private void EnemyInfoOpa_trackBar_Scroll(object sender, EventArgs e)
        {
            EnemyInfoOpa_textBox.Text = "" + EnemyInfoOpa_trackBar.Value;
        }

        private void EnemyInfoOpaZoom_trackBar_Scroll(object sender, EventArgs e)
        {
            EnemyInfoOpaZoom_textBox.Text = "" + EnemyInfoOpaZoom_trackBar.Value;
        }

        private void FriendSize_trackBar_Scroll(object sender, EventArgs e)
        {
            FriendSize_textBox.Text = "" + FriendSize_trackBar.Value;
        }

        private void FriendScale_trackBar_Scroll(object sender, EventArgs e)
        {
            FriendScale_textBox.Text = "" + FriendScale_trackBar.Value;
        }

        private void FriendIconOpa_trackBar_Scroll(object sender, EventArgs e)
        {
            FriendIconOpa_textBox.Text = "" + FriendIconOpa_trackBar.Value;
        }

        private void FriendIconOpaZoom_trackBar_Scroll(object sender, EventArgs e)
        {
            FriendIconOpaZoom_textBox.Text = "" + FriendIconOpaZoom_trackBar.Value;
        }

        private void FriendHealthOpa_trackBar_Scroll(object sender, EventArgs e)
        {
            FriendHealthOpa_textBox.Text = "" + FriendHealthOpa_trackBar.Value;
        }

        private void FriendHealthOpaZoom_trackBar_Scroll(object sender, EventArgs e)
        {
            FriendHealthOpaZoom_textBox.Text = "" + FriendHealthOpaZoom_trackBar.Value;
        }

        private void FriendInfoOpa_trackBar_Scroll(object sender, EventArgs e)
        {
            FriendInfoOpa_textBox.Text = "" + FriendInfoOpa_trackBar.Value;
        }

        private void FriendInfoOpaZoom_trackBar_Scroll(object sender, EventArgs e)
        {
            FriendInfoOpaZoom_textBox.Text = "" + FriendInfoOpaZoom_trackBar.Value;
        }
    }
}
