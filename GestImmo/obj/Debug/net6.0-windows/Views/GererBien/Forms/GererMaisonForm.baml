   M S B A M L   `   `   `  ����C  ?GestImmo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:GestImmo.Views.FormsGestImmo.Views.Forms  5      *    $GestImmo.Views.Forms.GererMaisonForm   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:GestImmo.Views.Forms     5        N� Title$  GererMaisonForm��5	      .��5      � $��15,15,15,15q�6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   6-   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� -   5         ��Name$ NomBien_TextBox��5      $��0��6+   $��1��68    �� TextWrapping$
 Wrap=�6H   $�� ��6\   $��Center=�6d   �� 5   
   -   5        $ ValeurBien_TextBox��5      $��1��6/   $��1��6<   $
 Wrap=�6L   $�� ��6`   $��Center=�6h   �� 5   
   -   5        $ AdresseBien_TextBox��5      $��2��6/   $��1��6<   $
 Wrap=�6L   $�� ��6`   $��Center=�6h   �� 5   
   -   5        $ SurfaceBien_TextBox��5      $��3��6/   $��1��6<   $
 Wrap=�6L   $�� ��6`   $��Center=�6h   �� 5    
   -   5        $ PiecesBien_TextBox��5       $��4��6.   $��1��6;   $
 Wrap=�6K   $�� ��6_   $��Center=�6g   �� 5!   
   -   5        $ ChambresBien_TextBox��5!      $��5��61   $��1��6>   $
 Wrap=�6N   $�� ��6b   $��Center=�6j   �� 5"   
   -   5        $ Cave_TextBox��5"      $��6��6)   $��1��66   $
 Wrap=�6F   $�� ��6Z   $��Center=�6b   �� 5#   
   -   5        $ Parking_TextBox��5#      $��7��6,   $��1��69   $
 Wrap=�6I   $�� ��6]   $��Center=�6e   �� 5%   
   -	   5         ��Name$ Lbl_NomBien��5%      $	��Nom��6%   $��0��64   $��0��6A   $��Center=�6Q   �� 5&   
   -
   5        $ Lbl_ValeurBien��5&      $��Valeur��6(   $��1��69   $��0��6F   $��Center=�6V   �� 5'   
   -   5        $ Lbl_AdresseBien��5'      $��Adresse��6)   $��2��6<   $��0��6I   $��Center=�6Y   �� 5(   
   -   5        $ Lbl_SurfaceBien��5(      $��Surface(m2)��6)   $��3��6?   $��0��6L   $��Center=�6\   �� 5)   
   -   5        $ Lbl_NbPieces��5)      $��Nombre de pièces��6&   $��4��6B   $��0��6O   $��Center=�6_   �� 5*   
   -   5        $ Lbl_NbChambre��5*      $��Nombre de chambres��6'   $��5��6D   $��0��6Q   $��Center=�6a   �� 5+   
   -   5        $ Lbl_Cave��5+      $
��Cave��6"   $��6��62   $��0��6?   $��Center=�6O   �� 5,   
   -   5        $ Lbl_Parking��5,      $��Place de parking��6%   $��7��6A   $��0��6N   $��Center=�6^   �� 5.   
   -   5         ��Name$ Bouton_Ajouter_Bien��5.      $��Ajouter une maison��6.   $��8��6K   $��1��6X   $��Center=�6h   6�   5/      50      