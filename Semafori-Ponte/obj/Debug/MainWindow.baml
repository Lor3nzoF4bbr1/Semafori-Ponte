   M S B A M L   `   `   `  ����I  ESemafori-Ponte, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Semafori_PonteSemafori_Ponte  5   	       Semafori_Ponte.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Semafori_Ponte     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ 	imgSfondo��5
      $��Sfondo ponte.png��6#   $��0,-21,0,-10q�6=    J� RenderTransformOrigin$ 0.5,0.5&�6R   $��0��6r   $��1��6�   �� 5   
   -   5        $ imgSemaforoRossoDestra��5      $��SemaforoRosso.png��60   $��525,10,199,338q�6K   $ 0.5,0.5&�6c   $��0��6�   $��1��6�   �� 5   
   -   5        $ imgSemaforoVerdeDestra��5      $��SemaforoVerde.png��60   $��525,10,199,338q�6K   $ 0.5,0.5&�6c   $��0��6�   $��1��6�   �� 5   
   -   5        $ imgSemaforoRossoSinistra��5      $��SemaforoRosso.png��62   $��193,10,531,338q�6M   $ 0.5,0.5&�6e   $��0��6�   $��1��6�   �� 5   
   -   5        $ imgSemaforoVerdeSinistra��5      $��SemaforoVerde.png��62   $��193,10,531,338q�6M   $ 0.5,0.5&�6e   $��0��6�   $��1��6�   �� 5   
   -   5        $ imgMacchinaDestra��5      $��Macchina-destra.png��6+   $��634,55,0,231q�6H   $ 0.5,0.5&�6^   $��0��6~   $��1��6�   �� 5   
   -   5        $ imgMacchinaSinistra��5      $��Macchina-sinistra.png��6-   $��0,127,643,169q�6L   $ 0.5,0.5&�6c   $��0��6�   $��1��6�   �� 5   
   -   5         ��Name$ btnStart��5      $��Start��6#   $
��Left=�63   $��
309,10,0,0q�6N   $	��Top=�6b   $	��144��6z   $��58��6�   $��20(�6�   6�   �� 5   
   -	   5         ��Name$ txtNMacchineSinistra��5      $
��Left=�60   $��30��6K   $��
29,332,0,0q�6W    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��141��6�   $��20(�6�   �� 5   
   -
   5        $ txtNMacchineDestra��5      $
��Left=�6.   $��36��6I   $��634,326,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��120��6�   $��20(�6�   �� 5   
   $!��Numero macchine 
a sinistra��6   $
��Left=�6:   $��
29,274,0,0q�6U   $	��Top=�6i   $	��141��6�   $��53��6�   $��16(�6�   �� 5   
   $��Numero macchine 
a destra��6   $
��Left=�68   $��634,268,0,0q�6S   $	��Top=�6h   $	��141��6�   $��53��6�   $��16(�6�   5      5      