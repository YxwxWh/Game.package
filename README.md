# Game.package
学习中使用MVC设计模式制作的背包系统
背包的数据使用了Json表存储，通过静态表（存储在本地的装备数据...）与动态表（存储在服务器的物品数量）合成后，刷新在背包界面
装备的分类显示通过Json表里的装备类型进行筛选后刷新在背包界面

装备的穿戴拿到从动态表传过来的数据后在背包进行查找ID对应的物品，然后再刷新在左侧的装备栏。
