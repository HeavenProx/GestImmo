   M S B A M L   `   `   `  ����C  ?GestImmo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:GestImmo.Views.FormsGestImmo.Views.Forms  5      /    )GestImmo.Views.Forms.GererAppartementForm   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:GestImmo.Views.Forms     5        N� Title$  GererAppartementForm��5
      .��5      � $��
15,15,15,0q�6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   6-   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5    
   �� -   5         ��Name$ NomBien_TextBox��5       $��0��6+   $��1��68    �� TextWrapping$
 Wrap=�6H   $�� ��6\   $��Center=�6d   �� 5!   
   -   5        $ ValeurBien_TextBox��5!      $��1��6/   $��1��6<   $
 Wrap=�6L   $�� ��6`   $��Center=�6h   �� 5"   
   -   5        $ AdresseBien_TextBox��5"      $��2��6/   $��1��6<   $
 Wrap=�6L   $�� ��6`   $��Center=�6h   �� 5#   
   -   5        $ SurfaceBien_TextBox��5#      $��3��6/   $��1��6<   $
 Wrap=�6L   $�� ��6`   $��Center=�6h   �� 5$   
   -   5        $ PiecesBien_TextBox��5$      $��4��6.   $��1��6;   $
 Wrap=�6K   $�� ��6_   $��Center=�6g   �� 5%   
   -   5        $ ChambresBien_TextBox��5%      $��5��61   $��1��6>   $
 Wrap=�6N   $�� ��6b   $��Center=�6j   �� 5&   
   -   5        $ Etage_Textbox��5&      $��6��6)   $��1��66   $
 Wrap=�6F   $�� ��6Z   $��Center=�6b   �� 5'   
   -   5        $ Ascenseur_TextBox��5'      $��7��6-   $��1��6:   $
 Wrap=�6J   $�� ��6^   $��Center=�6f   �� 5(   
   -	   5        $ Chauffage_TextBox��5(      $��8��6-   $��1��6:   $
 Wrap=�6J   $�� ��6^   $��Center=�6f   �� 5)   
   -
   5        $ Cave_TextBox��5)      $��9��6)   $��1��66   $
 Wrap=�6F   $�� ��6Z   $��Center=�6b   �� 5*   
   -   5        $ Parking_TextBox��5*      $��10��6,   $��1��6:   $
 Wrap=�6J   $�� ��6^   $��Center=�6f   �� 5,   
   -   5         ��Name$ Lbl_NomBien��5,      $	��Nom��6%   $��0��64   $��0��6A   $��Center=�6Q   �� 5-   
   -   5        $ Lbl_ValeurBien��5-      $��Valeur��6(   $��1��69   $��0��6F   $��Center=�6V   �� 5.   
   -   5        $ Lbl_AdresseBien��5.      $��Adresse��6)   $��2��6<   $��0��6I   $��Center=�6Y   �� 5/   
   -   5        $ Lbl_SurfaceBien��5/      $��Surface(m2)��6)   $��3��6?   $��0��6L   $��Center=�6\   �� 50   
   -   5        $ Lbl_NbPieces��50      $��Nombre de pièces��6&   $��4��6B   $��0��6O   $��Center=�6_   �� 51   
   -   5        $ Lbl_NbChambre��51      $��Nombre de chambres��6'   $��5��6D   $��0��6Q   $��Center=�6a   �� 52   
   -   5        $ Lbl_EtageAppartement��52      $��Etage��6.   $��6��6>   $��0��6K   $��Center=�6[   �� 53   
   -   5        $ Lbl_AscenseurAppartement��53      $��	Ascenseur��62   $��7��6F   $��0��6S   $��Center=�6c   �� 54   
   -   5        $ Lbl_ChauffageBien��54      $��	Chauffage��6+   $��8��6?   $��0��6L   $��Center=�6\   �� 55   
   -   5        $ Lbl_Cave��55      $
��Cave��6"   $��9��62   $��0��6?   $��Center=�6O   �� 56   
   -   5        $ Lbl_Parking��56      $��Place de parking��6%   $��10��6A   $��0��6O   $��Center=�6_   �� 58   
   -   5         ��Name$ Bouton_Ajouter_Bien��58      $��Ajouter un appartement��6.   $��11��6O   $��1��6]   $��Center=�6m   6�   5:      5;      