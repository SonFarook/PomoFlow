   M S B A M L   `   `   `  ����C  ?PomoFlow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PomoFlowPomoFlow  5      7 clr-namespace:PomoFlow.ViewModelPomoFlow.ViewModel  5      7 clr-namespace:PomoFlow.ViewModelPomoFlow.ViewModel  5          PomoFlow.App   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      (localclr-namespace:PomoFlow     5      6	viewmodel clr-namespace:PomoFlow.ViewModel     5      /vm clr-namespace:PomoFlow.ViewModel     5      X TXceed.Wpf.Toolkit, Version=4.7.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5        �� 	Resources  5
         Sarabun  SettingsViewModel �� Member  BackgroundColor1 �� Color �� Source  BackgroundColor2  ForegroundColor  PinWindowIcon H� Drawing I� ClipGeometry I� Opacity I� 	Transform � Brush	 � Geometry  SkipBreakIcon  CloseWindowButton
 �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� CornerRadius �� Triggers P� Property P� Value  MinimizeWindowButton �� BasedOn 	 MainWindowCheckBox �� Padding �� Triggers P� 
SourceName �� 
TargetName 
 MainPageLabel �� Value �� Binding �� RelativeSource �� Path  StartStopBtn J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius   ShadowDepth  SkipBreakBtn  RectangleButton#  Xceed.Wpf.Toolkit.ColorPicker  SettingsPageBtn��%�$  &	        &	 '     &	 ^     7  &	 �     7  &	 �     7  &	 �     &	 �    &	 �    &	 x    7  &		 )    &	
 T    7   &	 "    7   &	 �    7  '�� d    7   &	 @    '  �    &	 �    '_� "    7   *�5   
   /Fonts/#Sarabun)�66   �� 5   
   $# vm:SettingsViewModel.Instance��6-   �� 5   
    63   �� *BackgroundColor1+8   �� 5   
    63   �� *BackgroundColor2+8   �� 5   
    62   �� *ForegroundColor+8   H� 5   
    5      I� 5      4 ��        �    @V����@V����    �        	.��5      I� $ 1Q�6#   $ 0.1,0,0,-0.1,0,465W�6/   .��5      � # �  6*   �		 ����@V��        0     .�@     ձ@     ��@     ˱@     ��@     ��@     ��@     �@     .�@     j�@     �@     4�@     ��@     ��@     ��@     ��@     ��@     Z�@     6�@     ��@     f�@     ^�@     �@     ��@     ��@     ��@�Zcw     F�@�^�p     ��@Q�Q~d     ��@Q��b     ��@S@�`     �@��Z     :�@@� V     h�@S��SS     ��@@$�P     ��@�OPI     ��@S�_DA     ��@@�z?     ��@ ʚ;     `�@S@w�0     �@�,�+     j�@�ј     N�@S�{�     �@ v�     Т@�!'     ��@S@g�     ơ@��
     R�@@p�K@C�J�     z�@��	     �@@:i     ��@����     ��@ I     F�@@�v     ��@ ��     f�@�� )     Ҧ@@�-     <�@ ��3�     ��@ � ;     ȧ@� �?     ȧ@�mkH�     Ƨ@�'	O     ��@�o�P     ��@�\�U�     r�@@M�X     6�@�1�\     
�@��?_�     ��@�o�c     ��@     ��@     �@     "�@     ^�@     ��@     p�@     �@     ��@     >�@     ެ@     
�@     ڭ@     `�@     f�@     J�@     I�@     ؤ@     ��@     �@     (�@     0�@     ��@     .�@     �@     Χ@     ��@     $�@     �@     ��@     ��@     �@     �@     �@     ��@     B�@     ƫ@     ��@     X�@     ñ@     <�@     ˱@     �@     �@     ��@     �@     .�@     ձ@6U   � 5      # �  6*   �	 ����@V��        � �x�GI,��@1
 `� '�f��w�@�v��q��@1
�mb�D�@ ��J]Ӏ�� ��@�#� 	@��-�=u��	F �6� Q.?�ذ=�@m;�&rA�	58���D C8���D�@|�7���D ��,�?�9 �x�GI,6U   5      5      5      H� 5    
    5!      I� 5"      4 ��        �     ��� �� ��� ��    �        	.��5#      I� $ 1Q�6#   $ 0.1,0,0,-0.1,0,512W�6/   .��5$      � # �  6*   �	 �� �� ���        p��O     ��@S@~�     ��@ �     -�@�҇     ��@S��>     ��@@��%     ڬ@��@7     ��@S@�H     ��@�G�V     �@@�V     ��@S��|V     ��@�hG     J�@�R5@Yk�@qn@:rJ��}��>��@ �<��{���%8����Up3���@� 2Ӏ���;1@qwY��;1 ��\ b2�@�]��l2�֋_�a3��` �64��]c \6     Х@     P�@     ��@     ��@     �@     ��@     �@     
�@     ��@     P�@     Х@     ��@�]c     p�@��`     ��@S�֋_     ��@@�]     ��@ ��\     ��@S@h:Y     ǰ@��     İ@��O     ��@6T   � 5%      # �  6*   �	 �� �� ���        0     .�@     ��@     �@     ��@     ��@     ��@     l�@     j�@     <�@     F�@     >�@     ��@     n�@     ��@     ��@     ��@     r�@     ܬ@     ��@     ��@     �@     �@�     ��@���l�     :�@�A�T     8�@��@@     "�@�?�     
�@ $�=     ��@ �Q<     ��@@m;�     ��@@j_7     h�@ �B3     ��@ b2�     `�@��;1     4�@��;1     ��@@� 2�     ƫ@�1|2     �@ ��3     6�@ ��4�     ��@@a"7     ��@     �@     ��@     ��@     Ĳ@     ң@     Ĳ@     .�@     ��@     v�@     ��@     �@     ��@     c�@     6�@     ��@     �@     ��@     ƫ@     ��@     ��@     ��@     2�@     ư@     ��@     Ű@     .�@     ��@6T   5&      5'      5)      �� 5-   
   "
 ��6*   .�5.      ��  � ��# �  6+   �� 5/       � ��
 ���� 6,   �� 50       � ��$ 45��6&   �� 51       � |�$ False��6*   �� 52       � ��$ 34��6'   �� 53       � ��$ 0,0,0,1q�6'   �� 54       � �� 55      �� 56      " ��6&   .R�57      �� $ border��58      $��45��59      $��34��5:      $��Center=�5;      $��Center=�5<      #��z��5=      $ 0,10,0,0��5>      ._�5?      �� $��Center=�5@   !   $��Center=�5A   !   #��z��5B   !   $��Content��5C   !   5D      5E      5G       5H      P� 5I       �@J�IsMouseOver$
 True��61   . �5J      ��  � ��# �  63   5K      5M      �� 5Q   
   8   "
 ��5T      .�5U      ��  � �� 5V      �� 5W      " ��6&   .R�5X      �� #��z��6!   ._�5Y      �� 5Z      5[      5]      5^      �� 5b   
   "
 ��6+   .�5c      ��  � ��
 ���� 6,   �� 5d       � ��
 ���� 6+   �� 5e       � ��$ 25��6&   �� 5f       � ��$ 25��6'   �� 5g       � �� 5h      �� 5i      " ��6&   .R�5j      �� $��border��5k      $ 3q�5l      #��z��5m      $ 50��5n      ._�5o      �� $��Center=�5p   !   $��Center=�5q   !   #��z��5r   !   $��Content��5s   !   5t       5u      P� 5v      $ border��6&    �@J�IsMouseOver$
 True��6Q   . �5w   "   �� $ border��6)   # �  6S    � ��5x      5z      5|       5}      P� 5~       �@d�	IsChecked$
 TrueY�6/   . �5      ��  � ��# �  63   5�      P� 5�       �@d�	IsChecked$ FalseY�6/   . �5�      ��  � ��
 ���� 63   5�      5�      �� 5�   
   "
 ��6&   .�5�      ��  � ��$
 0,15q�6'   �� 5�       � ��
 ���� 6+   �� 5�       � ��$ 75��6&   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� $	 5,4q�5�      #��z��5�      $ 10��5�      ._�5�      �� $
��text��5�   !   $
��Auto��5�   !   $��Center=�5�   !   $��Center=�5�   !   8��  $��12(�5�   !   $��Regular"�5�   !   #���  5�   !   #��z��5�   !   5�       5�      �� 5�      $
 True��6m    6*   ��  �� *Self+$	 Tag�.a�5�   "   �� # �  6?    � ���� 5�   "   $
 text��6)   # �  6Q    � ���� 5�   "   $
 text��6)    � ��$
 Bold"�6Q   5�      5�      5�      5�      �� 5�   
   "
 ��6%   .�5�      ��  � ��$ 75��6&   �� 5�       � ��$ 25��6'   �� 5�       � ��# �  6+   �� 5�       � ��8   6+   �� 5�       � ��$ Start��6(   �� 5�       � ��$ 13(�6)   �� 5�       � |�$ False��6*   �� 5�       � ��# �  6+   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� #��z��6!   $ 12��6K    5�        5�   "   $ 5Q�63   $ 1Q�6B   ._�5�      �� $��Center=�5�   !   $��Center=�5�   !   #��z��5�   !   $��Content��5�   !   5�      5�      5�       5�      P� 5�       �@J�IsMouseOver$
 True��61   . �5�      ��  �@J�Opacity$	 0.9Q�60   5�      5�      �� 5�   
   8   "
 ��5�      .�5�      ��  � y�$ Hidden=�6+   �� 5�       � ��
 ���� 6+    5�      P� 5�       �@J�IsMouseOver$
 True��61   . �5�      ��  �@J�Opacity$	 0.8Q�60   5�      �� 5�       6   ��  �� *Self+$	 Tag� True6a   .a�5�      ��  � y�$ Visible=�63   5�      5�      �� 5�   
   "
 ��6   .�5�      ��  � ��$ Center=�62   �� 5�       � ��$ Center=�64   �� 5�       � ��# �  6+   �� 5�       � ��8   6+   �� 5�       � ��$
 Bold"�6+   5�      �� 5�   
   "
 ��6(   .�5�      ��  � ��# �  6,   �� 5�       � ��$ 1q�60   �� 5�       � ��$ 12��6&   �� 5�       � ��$ 12��6'   �� 5�       � ��$ Right=�64   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� #��z��5�      #��z��5�      #��z��5�      ._�5�      �� $��Center=�6/   $��Center=�6L   5�      5�      5�      5�      �� 5   
   "
  6   .�5     ��  � ��$ 13��6'   �� 5      � ��$ 13��6&   �� 5      �@J�Opacity$ 0Q�6(   �� 5      � ��$	 Top=�62   �� 5      � ��$ Center=�64   �� 5      �@�ToolTip$  Click to choose a color :)��6(    5     P� 5      �@J�IsMouseOver$
 True��61   . �5	     ��  �@�Cursor$
 Hand��6/   5
     5     �� 5  
   "
 ��6(   .�5     ��  � ��
 ���� 6,   �� 5      � ��
 ���� 6+   �� 5      � ��$ 25��6&   �� 5      � ��$ 25��6'   �� 5      � �� 5     �� 5     " ��6&   .R�5     �� $��border��5     $��25��5     $��25��5     $ 2q�5     #��z��5     $ 50��5     ._�5     �� $��Center=�5   !   $��Center=�5!  !   #��z��5"  !   $��Content��5#  !   5$      5%     P� 5&     $ border��6&    �@J�IsMouseOver$
 True��6Q   . �5'  "   �� $ border��6)   # �  6S    � ��5(     5*     5,     5-     �� 50  
   "
 _�6   .�51     ��  � ��# �  6+   �� 52      � ��# �  6,   �� 53      � ��# �  6+   �� 54      � ��$ 2q�60   �� 55      � ��8   6+   �� 56      � ��$ Regular"�6+   �� 57      � �� 58     �� 59     " _�6&   .R�5:     �� $	 5,3q�5;     #��z��5<     #��z��5=     #��z��5>     $ 5��5?     ._�5@     �� $��Center=�6/   $��Center=�6L   5A     5B     5D     5E     5G     5H     