using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U3_HaNgMaN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayHangman_Click(object sender, RoutedEventArgs e)
        {
            PlayHangman.Visibility = Visibility.Collapsed;
            A.Visibility = Visibility.Visible;
            B.Visibility = Visibility.Visible;
            C.Visibility = Visibility.Visible;
            D.Visibility = Visibility.Visible;
            E.Visibility = Visibility.Visible;
            F.Visibility = Visibility.Visible;
            G.Visibility = Visibility.Visible;
            H.Visibility = Visibility.Visible;
            I.Visibility = Visibility.Visible;
            J.Visibility = Visibility.Visible;
            K.Visibility = Visibility.Visible;
            L.Visibility = Visibility.Visible;
            M.Visibility = Visibility.Visible;
            N.Visibility = Visibility.Visible;
            O.Visibility = Visibility.Visible;
            P.Visibility = Visibility.Visible;
            Q.Visibility = Visibility.Visible;
            R.Visibility = Visibility.Visible;
            S.Visibility = Visibility.Visible;
            T.Visibility = Visibility.Visible;
            U.Visibility = Visibility.Visible;
            V.Visibility = Visibility.Visible;
            W.Visibility = Visibility.Visible;
            X.Visibility = Visibility.Visible;
            Y.Visibility = Visibility.Visible;
            Z.Visibility = Visibility.Visible;
        }

        private void Z_Click(object sender, RoutedEventArgs e)
        {
            Z.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;

        }

        private void Y_Click(object sender, RoutedEventArgs e)
        {
            Y.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void X_Click(object sender, RoutedEventArgs e)
        {
            X.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void W_Click(object sender, RoutedEventArgs e)
        {
            W.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void V_Click(object sender, RoutedEventArgs e)
        {
            V.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void U_Click(object sender, RoutedEventArgs e)
        {
            U.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void T_Click(object sender, RoutedEventArgs e)
        {
            T.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void S_Click(object sender, RoutedEventArgs e)
        {
            S.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void R_Click(object sender, RoutedEventArgs e)
        {
            R.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void Q_Click(object sender, RoutedEventArgs e)
        {
            Q.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void P_Click(object sender, RoutedEventArgs e)
        {
            P.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void O_Click(object sender, RoutedEventArgs e)
        {
            O.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void N_Click(object sender, RoutedEventArgs e)
        {
            N.Visibility = Visibility.Collapsed;
            WordN.Visibility = Visibility.Visible;
            WordN2.Visibility = Visibility.Visible;
        }

        private void L_Click(object sender, RoutedEventArgs e)
        {
            L.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void M_Click(object sender, RoutedEventArgs e)
        {
            M.Visibility = Visibility.Collapsed;
            WordM.Visibility = Visibility.Visible; 
        }

        private void K_Click(object sender, RoutedEventArgs e)
        {
            K.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void J_Click(object sender, RoutedEventArgs e)
        {
            J.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void I_Click(object sender, RoutedEventArgs e)
        {
            I.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void H_Click(object sender, RoutedEventArgs e)
        {
            H.Visibility = Visibility.Collapsed;
            WordH.Visibility = Visibility.Visible;
        }

        private void G_Click(object sender, RoutedEventArgs e)
        {
            G.Visibility = Visibility.Collapsed;
            WordG.Visibility = Visibility.Visible;
        }

        private void F_Click(object sender, RoutedEventArgs e)
        {
            F.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void E_Click(object sender, RoutedEventArgs e)
        {
            E.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void D_Click(object sender, RoutedEventArgs e)
        {
            D.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            C.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            B.Visibility = Visibility.Collapsed;
            YouLose.Visibility = Visibility.Visible;
        }

        private void A_Click(object sender, RoutedEventArgs e)
        {
            A.Visibility = Visibility.Collapsed;
            WordA.Visibility = Visibility.Visible;
            WordA2.Visibility = Visibility.Visible;
        }
      
    }
}