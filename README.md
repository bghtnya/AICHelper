# AICHelper / AliceInCradle辅助工具 / ct表
当前版本：1.3

## 界面
![image](https://github.com/user-attachments/assets/aedf36f1-80a4-40be-bf01-b35a1d0b41c4)
![image](https://github.com/user-attachments/assets/394c4c07-8b65-44b1-a7c0-e87ff8f3a14c)



## 更新日志

### 1.3
- 优化空间布局，修复部分内存操作问题
- 支持对 F7 调试菜单部分F7调试菜单指令的支持

### 1.2
- 删除了大部分与 CE 重复的内存功能

## 辅助工具支持功能
- [x] 对游戏 AliceInCradle 部分内存的操作: 修改坐标/HP/MP
- [x] 对调试文件 `_debug.txt` 的快捷修改
- [x] 对F7调试菜单哈语言指令的支持


## ct表支持功能
- [x] 人物结构指针
- [x] 部分函数地址
- [x] 修改金币数量
- [x] 无视虫墙
- [x] 允许随时保存
- [x] 停止绘制流体
- [x] 无限氧气

## 游戏内置F7调试菜单支持功能
- [x] 一击必杀
- [x] 无敌
- [x] 虚弱
- [x] 解锁所有技能
- [x] 修改事件
- [x] 修改天气/生命值/坐标/金币
- [x] 获取物品
- [x] 查看魔物列表
- [x] 允许在夜晚使用快速旅行
- [x] 修改/锁定危险度

## 游戏内置_debug.txt支持功能
- [x] 开启调试(<DEBUG>)
- [x] 不加载声音(nosnd)
- [x] F9重载(reloadmtr)
- [x] 提示健全(nocfg)
- [x] 一击必杀(mighty)
- [x] 无敌(nodamage)
- [x] 虚弱(weak)
- [x] 解锁所有技能(allskill)
- [x] 超气旋?(supercyclone)
- [x] 日志通告(annouce)
- [x] 显示时间戳(timestamp)
- [x] 不知道干什么的(_player)
- [x] 无事件(noevent)
- [x] 基准(benchmark)
- [x] 稳定绘制(stabilize draw)
- [x] 无语音(novoice)
- [x] 敏感(sensitive)
- [x] 规格(speffect)

## 使用说明
首次使用辅助工具请先打开游戏进程点击 进程初始化 或 拖入游戏文件夹 \
F7调试菜单需要同时打开日志与时间戳功能 可以在辅助工具内一键开启 \
ct表的使用需要先下载安装Cheat Engine, 导入ct文件 然后附加游戏进程,注意部分功能需要在附加游戏后从ce菜单中激活mono功能才能获取到函数地址

具体教程见 B 站视频：
- [【【开源】AliceInCradle 辅助工具 v1.1 新增 debug 调试支持](https://www.bilibili.com/video/BV1SY41197J6/)
- [【AliceInCradle 辅助工具(附 CT 表)】](https://www.bilibili.com/video/BV1vP4y197x9/)
