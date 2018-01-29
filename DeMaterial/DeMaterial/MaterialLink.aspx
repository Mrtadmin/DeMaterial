<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaterialLink.aspx.cs" Inherits="DeMaterial.MaterialLink" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <title>材料预览</title>

<link rel="stylesheet" href="css/style.css">
    <script src="Script/jquery.min.js"></script>
    <script src="Script/YuxiSlider.jQuery.min.js"></script>
</head>

<body>
<div class="demo">
	<a class="control prev"></a><a class="control next abs"></a><!--自定义按钮，移动端可不写-->
	<div class="slider"><!--主体结构，请用此类名调用插件，此类名可自定义-->
		<ul style="text-align:center;">
			<li><a href=""><img src="Image/3D复古砖墙大型壁画.jpg" /></a></li>
			<li><a href=""><img src="Image/3D立体墙纸蒲公英无缝墙布.jpg"  /></a></li>
			<li><a href=""><img src="Image/loft工业风门酒吧门.jpg"  /></a></li>
			<li><a href=""><img src="Image/3d立体墙纸卧室客厅.jpg"/></a></li>
			<li><a href=""><img src="Image/2门衣柜推拉门.jpg"  /></a></li>
		</ul>
	</div>
</div>
<script src="js/jquery.min.js"></script>
<script src="js/YuxiSlider.jQuery.min.js"></script>
<script>
    $(".slider").YuxiSlider({
        width: 800, //容器宽度
        height: 450, //容器高度
        control: $('.control'), //绑定控制按钮
        during: 4000, //间隔4秒自动滑动
        speed: 800, //移动速度0.8秒
        mousewheel: true, //是否开启鼠标滚轮控制
        direkey: true //是否开启左右箭头方向控制
    });
</script>
</body>
</html>