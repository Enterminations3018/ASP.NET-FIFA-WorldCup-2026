# 🏆 ASP.NET FIFA World Cup 2026 Dashboard

> 基于 **ASP.NET Core Blazor Web App** 构建的 2026 年美加墨世界杯一站式资讯、数据与预测面板 — 赛程赛果、球队积分榜、球队实力榜、金靴预测、16 座球场巡礼、赛事前瞻/赛果新闻 7 大模块全部可交互、支持多维排序和筛选。

---

## ✨ 功能特色

| # | 模块 | 路由 | 亮点 |
|---|---|---|---|
| 🏠 | 1. 首页 Hero 总览 | `/` | 倒计时横幅、16 支参赛队概览、最新比赛 + 焦点新闻快览 |
| 📅 | 2. 赛程赛果 | `/matches` | **三档状态高亮筛选**：已结束 / 进行中 / 未开始，Query String 持久化状态 |
| 🏅 | 3. 球队积分榜 & 球队列表 | `/teams` | **积分榜 ↔ 球队列表** 双向切换，真实积分规则（胜 3 / 平 1 / 负 0） |
| 🏆 | 4. 球队实力榜 | `/rankings` | 进攻 / 中场 / 防守 / 门将 / FIFA 排名 / 夺冠概率 **7 种排序**，前 4 第一梯队高亮 |
| ⚽ | 5. 金靴奖预测 | `/scorers` | 14 位顶级射手预测进球、世界杯历史进球、国家队进球、身价、年龄 **7 种排序** |
| 🏟️ | 6. 16 座球场巡礼 | `/stadiums` | 2026 官方公布的美加墨 16 座球场，按容量 / 国家 / 城市 **4 种排序**，≥8 万人球场高亮 |
| 📰 | 7. 赛事新闻资讯 | `/news` | 包含 C 罗、莫德里奇、梅西、姆巴佩等真实球星的前瞻/赛果资讯 |

---

## 🚀 快速开始

### 环境要求

| 依赖 | 最低版本 | 检查命令 |
|---|---|---|
| .NET SDK | **10.0+** | `dotnet --list-sdks` |
| Git | 2.40+ | `git --version` |

> 💡 一键安装 .NET 10 SDK（Windows）：
> ```powershell
> winget install Microsoft.DotNet.SDK.10
> ```

### 方式 A：命令行跑起来（最简单）

```powershell
git clone https://github.com/Enterminations3018/ASP.NET-FIFA-WorldCup-2026.git
cd ASP.NET-FIFA-WorldCup-2026
dotnet run
```

启动成功后浏览器打开 **http://localhost:5000/** （或控制台输出的监听地址）。

### 方式 B：Visual Studio

双击 `ASP.slnx`（需要 Visual Studio 2022 17.8+ 以支持新版 SLNX 解决方案格式）→ 按 `F5`。

### 方式 C：Visual Studio Code

1. `File → Open Folder` 选择项目根目录
2. 安装推荐扩展 **C# Dev Kit**
3. 左侧「运行和调试」→ 选 **.NET Core Launch (web)** → 按 `F5`

### 常用命令速查

```powershell
# 仅编译（验证代码没错，不启动网站）
dotnet build

# Release 发布（适合发给朋友双击运行）
dotnet publish -c Release -r win-x64 --self-contained false -p:PublishSingleFile=true -o ./publish

# 发布后运行
./publish/WorldCup2026.exe
```

---

## 🧩 核心模块详解

### 4. 实力榜 `/rankings`

点击顶部 7 个排序按钮或在 URL 加 `?sort=` 参数切换：

| `?sort=` | 排序维度 | 第一 |
|---|---|---|
| `overall`（默认） | 综合分（进攻×0.4 + 中场×0.3 + 防守×0.2 + 门将×0.1） | 🇦🇷 阿根廷 |
| `attack` | 进攻能力 | 🇫🇷 法国 95 |
| `midfield` | 中场掌控 | 🇪🇸 西班牙 93 |
| `defense` | 防守硬度 | 🇲🇦 摩洛哥 88 |
| `gk` | 门将水准 | 🇦🇷 阿根廷 88 |
| `fifa` | FIFA 官方排名 | 🇦🇷 阿根廷（第 1） |
| `winprob` | 夺冠概率（综合赔率模拟） | 🇦🇷 阿根廷 18.5% |

### 5. 金靴预测 `/scorers`

`?sort=` 参数：`predicted` / `worldcup` / `national` / `value` / `age_asc` / `age_desc` / `position`

- 🥇 历史进球：梅西 13 · C 罗 8 · 姆巴佩 8
- 🏟️ 国家队进球：C 罗 138 · 梅西 112 · 莱万 84
- 💎 身价：哈兰德 €200M · 姆巴佩 €180M · 维尼修斯 €180M

### 6. 球场巡礼 `/stadiums`

`?sort=` 参数：`capacity_desc` / `capacity_asc` / `country` / `city`

| 国家 | 球场数 | 代表球场 |
|---|---|---|
| 🇺🇸 美国 | 11 座 | 大都会人寿体育场（82,500）AT&T 体育场（80,000） |
| 🇲🇽 墨西哥 | 3 座 | 阿兹特克（87,523 · 全场最大） |
| 🇨🇦 加拿大 | 2 座 | BC Place（54,500）· BMO Field（45,736） |

---

## 📦 技术栈

| 层级 | 技术 |
|---|---|
| 框架 | **ASP.NET Core 10** · Blazor Web App（Static SSR） |
| UI 组件 | **Bootstrap 5**（内联 SVG 图标，无需图标字体） |
| 渲染模式 | **Static Server-Side Rendering**（Query String 驱动页面状态，无 WebSocket 依赖） |
| 组织模式 | Components → Pages / Layout，Models + Services 分层，无 EF/数据库依赖 |
| 编译器 | Roslyn（.NET SDK 内置） |

---

## 📁 项目结构

```
ASP.NET-FIFA-WorldCup-2026/
├── Components/
│   ├── Layout/
│   │   ├── MainLayout.razor            # 主框架布局 + 侧边栏容器
│   │   ├── NavMenu.razor               # 左侧 7 项导航（带 SVG 图标）
│   │   └── ReconnectModal.razor        # 重连提示组件
│   └── Pages/
│       ├── Home.razor                  # 🏠 首页
│       ├── Matches.razor               # 📅 赛程赛果（3 档状态筛选）
│       ├── Teams.razor                 # 🏅 积分榜 ↔ 球队列表切换
│       ├── Rankings.razor              # 🏆 实力榜（7 种排序）
│       ├── TopScorers.razor            # ⚽ 金靴预测榜（7 种排序）
│       ├── Stadiums.razor              # 🏟️ 球场巡礼（4 种排序）
│       ├── News.razor                  # 📰 新闻资讯
│       ├── Error.razor                 # 500 错误页
│       └── NotFound.razor              # 404 页
├── Models/
│   ├── Team.cs · Match.cs · News.cs
│   ├── Player.cs · PowerRanking.cs · Stadium.cs
├── Services/
│   └── WorldCupService.cs              # 1 份服务类提供全部 7 页面数据（真实基础+合理预测）
├── wwwroot/
│   ├── lib/bootstrap/                  # Bootstrap 5 CSS + JS 已内置
│   └── favicon.png
├── Program.cs                          # 入口：注册服务 + 启用 Blazor SSR 管线
├── WorldCup2026.csproj                 # 项目配置（net10.0 + Nullable + ImplicitUsings）
├── appsettings.json                    # 运行配置（Logging + AllowedHosts，无敏感信息）
├── .gitignore                          # ASP.NET 专用（bin/obj/密钥/缓存全排除）
├── .gitattributes                      # 跨平台行尾 + 二进制 diff 归一化
└── ASP.slnx                            # 新版解决方案（VS 2022 17.8+）
```

---

## 📝 数据说明

- **球队 / 国旗 / FIFA 排名**：基于 2024-2026 公开 FIFA 排名和已知晋级路径模拟。
- **比赛比分 / 进球 / 结果**：仅为开发演示用途的**合理预测数据**，**非真实世界杯官方结果**，项目上线时赛事尚未开赛。
- **新闻内容**：均基于真实球星过往表现、赛前舆论、转会传闻等公开信息撰写的前瞻类文章，不构成任何投注建议。
- **实力榜评分 / 夺冠概率 / 金靴预测进球**：综合 FIFA 排名、俱乐部近期表现、球员身价、历史大赛数据等多维度加权模拟，仅供参考。

> ⚠️ 本项目为**学习与演示用途的球迷面板**，与 FIFA、世界杯官方、任何参赛足协均无直接关联，不构成任何官方资讯。

---

## 🤝 贡献指南

欢迎 PR / Issue！建议提 PR 前先开 Issue 讨论一下避免做重复工作：

1. Fork 本仓库
2. 新建功能分支：`git checkout -b feature/amazing-feature`
3. 提交：`git commit -m 'feat: add amazing feature'`（建议遵循 Conventional Commits 规范）
4. 推送：`git push origin feature/amazing-feature`
5. 开 Pull Request → 勾上「Allow maintainers to edit」

本地改完代码记得跑一下 `dotnet build` 确认 **0 警告 0 错误** 再提 PR 😄

---

## 📄 License

本项目采用 **MIT License**（最宽松，允许商用、修改、分发、私人使用，只要求保留版权声明）。
详情见 [LICENSE](./LICENSE)。

---

<p align="center">Made with ⚽ + ❤️ by <a href="https://github.com/Enterminations3018">Enterminations3018</a></p>
