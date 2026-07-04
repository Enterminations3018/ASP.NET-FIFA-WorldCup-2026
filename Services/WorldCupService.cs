using WorldCup2026.Models;

namespace WorldCup2026.Services;

public interface IWorldCupService
{
    List<Team> GetTeams();
    List<Match> GetMatches();
    List<News> GetNews();
    Dictionary<string, List<Team>> GetStandings();
    List<Stadium> GetStadiums();
    List<Player> GetTopScorerCandidates();
    List<PowerRanking> GetPowerRankings();
}

public class WorldCupService : IWorldCupService
{
    private readonly List<Team> _teams = new()
    {
        new Team { Id = 1, Name = "墨西哥", Country = "Mexico", Group = "A", FlagUrl = "🇲🇽" },
        new Team { Id = 2, Name = "加拿大", Country = "Canada", Group = "A", FlagUrl = "🇨🇦" },
        new Team { Id = 3, Name = "波兰", Country = "Poland", Group = "A", FlagUrl = "🇵🇱" },
        new Team { Id = 4, Name = "沙特阿拉伯", Country = "Saudi Arabia", Group = "A", FlagUrl = "🇸🇦" },

        new Team { Id = 5, Name = "美国", Country = "USA", Group = "B", FlagUrl = "🇺🇸" },
        new Team { Id = 6, Name = "英格兰", Country = "England", Group = "B", FlagUrl = "🇬🇧" },
        new Team { Id = 7, Name = "日本", Country = "Japan", Group = "B", FlagUrl = "🇯🇵" },
        new Team { Id = 8, Name = "塞内加尔", Country = "Senegal", Group = "B", FlagUrl = "🇸🇳" },

        new Team { Id = 9, Name = "阿根廷", Country = "Argentina", Group = "C", FlagUrl = "🇦🇷" },
        new Team { Id = 10, Name = "法国", Country = "France", Group = "C", FlagUrl = "🇫🇷" },
        new Team { Id = 11, Name = "澳大利亚", Country = "Australia", Group = "C", FlagUrl = "🇦🇺" },
        new Team { Id = 12, Name = "突尼斯", Country = "Tunisia", Group = "C", FlagUrl = "🇹🇳" },

        new Team { Id = 13, Name = "巴西", Country = "Brazil", Group = "D", FlagUrl = "🇧🇷" },
        new Team { Id = 14, Name = "西班牙", Country = "Spain", Group = "D", FlagUrl = "🇪🇸" },
        new Team { Id = 15, Name = "德国", Country = "Germany", Group = "D", FlagUrl = "🇩🇪" },
        new Team { Id = 16, Name = "摩洛哥", Country = "Morocco", Group = "D", FlagUrl = "🇲🇦" },
    };

    private readonly List<Match> _matches = new()
    {
        new Match {
            Id = 1,
            MatchDate = DateTime.Parse("2026-06-11 16:00"),
            Stage = "小组赛",
            Venue = "墨西哥城阿兹特克体育场",
            HomeTeam = new Team { Name = "墨西哥", FlagUrl = "🇲🇽" },
            AwayTeam = new Team { Name = "波兰", FlagUrl = "🇵🇱" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 2,
            MatchDate = DateTime.Parse("2026-06-11 20:00"),
            Stage = "小组赛",
            Venue = "多伦多 BMO 球场",
            HomeTeam = new Team { Name = "加拿大", FlagUrl = "🇨🇦" },
            AwayTeam = new Team { Name = "沙特阿拉伯", FlagUrl = "🇸🇦" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 3,
            MatchDate = DateTime.Parse("2026-06-15 16:00"),
            Stage = "小组赛",
            Venue = "墨西哥城阿兹特克体育场",
            HomeTeam = new Team { Name = "墨西哥", FlagUrl = "🇲🇽" },
            AwayTeam = new Team { Name = "沙特阿拉伯", FlagUrl = "🇸🇦" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 4,
            MatchDate = DateTime.Parse("2026-06-15 20:00"),
            Stage = "小组赛",
            Venue = "温哥华 BC 广场",
            HomeTeam = new Team { Name = "加拿大", FlagUrl = "🇨🇦" },
            AwayTeam = new Team { Name = "波兰", FlagUrl = "🇵🇱" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 5,
            MatchDate = DateTime.Parse("2026-06-19 16:00"),
            Stage = "小组赛",
            Venue = "瓜达拉哈拉阿克伦体育场",
            HomeTeam = new Team { Name = "墨西哥", FlagUrl = "🇲🇽" },
            AwayTeam = new Team { Name = "加拿大", FlagUrl = "🇨🇦" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 6,
            MatchDate = DateTime.Parse("2026-06-19 20:00"),
            Stage = "小组赛",
            Venue = "蒙特雷BBVA球场",
            HomeTeam = new Team { Name = "波兰", FlagUrl = "🇵🇱" },
            AwayTeam = new Team { Name = "沙特阿拉伯", FlagUrl = "🇸🇦" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },

        new Match {
            Id = 7,
            MatchDate = DateTime.Parse("2026-06-12 16:00"),
            Stage = "小组赛",
            Venue = "纽约大都会人寿体育场",
            HomeTeam = new Team { Name = "美国", FlagUrl = "🇺🇸" },
            AwayTeam = new Team { Name = "英格兰", FlagUrl = "🇬🇧󠁧󠁢󠁥󠁮󠁧󠁿" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 8,
            MatchDate = DateTime.Parse("2026-06-12 20:00"),
            Stage = "小组赛",
            Venue = "洛杉矶 SoFi 体育场",
            HomeTeam = new Team { Name = "日本", FlagUrl = "🇯🇵" },
            AwayTeam = new Team { Name = "塞内加尔", FlagUrl = "🇸🇳" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 9,
            MatchDate = DateTime.Parse("2026-06-16 16:00"),
            Stage = "小组赛",
            Venue = "西雅图流明球场",
            HomeTeam = new Team { Name = "美国", FlagUrl = "🇺🇸" },
            AwayTeam = new Team { Name = "日本", FlagUrl = "🇯🇵" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 10,
            MatchDate = DateTime.Parse("2026-06-16 20:00"),
            Stage = "小组赛",
            Venue = "亚特兰大梅赛德斯-奔驰体育场",
            HomeTeam = new Team { Name = "英格兰", FlagUrl = "🇬🇧󠁧󠁢󠁥󠁮󠁧󠁿" },
            AwayTeam = new Team { Name = "塞内加尔", FlagUrl = "🇸🇳" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 11,
            MatchDate = DateTime.Parse("2026-06-20 16:00"),
            Stage = "小组赛",
            Venue = "芝加哥军人球场",
            HomeTeam = new Team { Name = "美国", FlagUrl = "🇺🇸" },
            AwayTeam = new Team { Name = "塞内加尔", FlagUrl = "🇸🇳" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 12,
            MatchDate = DateTime.Parse("2026-06-20 20:00"),
            Stage = "小组赛",
            Venue = "费城林肯金融球场",
            HomeTeam = new Team { Name = "英格兰", FlagUrl = "🇬🇧󠁧󠁢󠁥󠁮󠁧󠁿" },
            AwayTeam = new Team { Name = "日本", FlagUrl = "🇯🇵" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },

        new Match {
            Id = 13,
            MatchDate = DateTime.Parse("2026-06-13 16:00"),
            Stage = "小组赛",
            Venue = "迈阿密硬石体育场",
            HomeTeam = new Team { Name = "阿根廷", FlagUrl = "🇦🇷" },
            AwayTeam = new Team { Name = "法国", FlagUrl = "🇫🇷" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 14,
            MatchDate = DateTime.Parse("2026-06-13 20:00"),
            Stage = "小组赛",
            Venue = "堪萨斯城箭头球场",
            HomeTeam = new Team { Name = "澳大利亚", FlagUrl = "🇦🇺" },
            AwayTeam = new Team { Name = "突尼斯", FlagUrl = "🇹🇳" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 15,
            MatchDate = DateTime.Parse("2026-06-17 16:00"),
            Stage = "小组赛",
            Venue = "休斯顿NRG体育场",
            HomeTeam = new Team { Name = "阿根廷", FlagUrl = "🇦🇷" },
            AwayTeam = new Team { Name = "澳大利亚", FlagUrl = "🇦🇺" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 16,
            MatchDate = DateTime.Parse("2026-06-17 20:00"),
            Stage = "小组赛",
            Venue = "达拉斯 AT&T 体育场",
            HomeTeam = new Team { Name = "法国", FlagUrl = "🇫🇷" },
            AwayTeam = new Team { Name = "突尼斯", FlagUrl = "🇹🇳" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 17,
            MatchDate = DateTime.Parse("2026-06-21 16:00"),
            Stage = "小组赛",
            Venue = "波士顿吉列球场",
            HomeTeam = new Team { Name = "阿根廷", FlagUrl = "🇦🇷" },
            AwayTeam = new Team { Name = "突尼斯", FlagUrl = "🇹🇳" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 18,
            MatchDate = DateTime.Parse("2026-06-21 20:00"),
            Stage = "小组赛",
            Venue = "丹佛英里高球场",
            HomeTeam = new Team { Name = "法国", FlagUrl = "🇫🇷" },
            AwayTeam = new Team { Name = "澳大利亚", FlagUrl = "🇦🇺" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },

        new Match {
            Id = 19,
            MatchDate = DateTime.Parse("2026-06-14 16:00"),
            Stage = "小组赛",
            Venue = "达拉斯 AT&T 体育场",
            HomeTeam = new Team { Name = "巴西", FlagUrl = "🇧🇷" },
            AwayTeam = new Team { Name = "西班牙", FlagUrl = "🇪🇸" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 20,
            MatchDate = DateTime.Parse("2026-06-14 20:00"),
            Stage = "小组赛",
            Venue = "奥兰多露营世界球场",
            HomeTeam = new Team { Name = "德国", FlagUrl = "🇩🇪" },
            AwayTeam = new Team { Name = "摩洛哥", FlagUrl = "🇲🇦" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 21,
            MatchDate = DateTime.Parse("2026-06-18 16:00"),
            Stage = "小组赛",
            Venue = "华盛顿联邦快递球场",
            HomeTeam = new Team { Name = "巴西", FlagUrl = "🇧🇷" },
            AwayTeam = new Team { Name = "德国", FlagUrl = "🇩🇪" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 22,
            MatchDate = DateTime.Parse("2026-06-18 20:00"),
            Stage = "小组赛",
            Venue = "旧金山李维斯球场",
            HomeTeam = new Team { Name = "西班牙", FlagUrl = "🇪🇸" },
            AwayTeam = new Team { Name = "摩洛哥", FlagUrl = "🇲🇦" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 23,
            MatchDate = DateTime.Parse("2026-06-22 16:00"),
            Stage = "小组赛",
            Venue = "明尼阿波利斯美国银行球场",
            HomeTeam = new Team { Name = "巴西", FlagUrl = "🇧🇷" },
            AwayTeam = new Team { Name = "摩洛哥", FlagUrl = "🇲🇦" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
        new Match {
            Id = 24,
            MatchDate = DateTime.Parse("2026-06-22 20:00"),
            Stage = "小组赛",
            Venue = "凤凰城州农场球场",
            HomeTeam = new Team { Name = "西班牙", FlagUrl = "🇪🇸" },
            AwayTeam = new Team { Name = "德国", FlagUrl = "🇩🇪" },
            HomeScore = null,
            AwayScore = null,
            IsFinished = false,
            Status = "未开始"
        },
    };

    private readonly List<News> _news = new()
    {
        new News {
            Id = 1,
            Title = "2026 世界杯盛大开幕！墨西哥城阿兹特克体育场迎来首场比赛",
            Summary = "第 23 届 FIFA 世界杯在墨西哥城正式拉开帷幕，这是世界杯历史上首次在三个国家联合举办。",
            Content = "2026 年 6 月 11 日，墨西哥城阿兹特克体育场座无虚席，来自世界各地的球迷共同见证了这一历史时刻。本届世界杯由美国、加拿大和墨西哥联合举办，共有 16 支球队将在 16 座体育场展开激烈角逐！开幕式上精彩的文艺表演展现了三国文化的交融，墨西哥著名歌手献唱了本届世界杯主题曲。",
            PublishDate = DateTime.Parse("2026-06-11"),
            ImageUrl = "",
            Source = "FIFA 官方"
        },
        new News {
            Id = 2,
            Title = "开幕战前瞻：墨西哥 vs 波兰 东道主对阵欧洲劲旅",
            Summary = "A组首轮焦点战，墨西哥坐镇主场迎战由莱万多夫斯基领衔的波兰队，双方都希望取得开门红。",
            Content = "本届世界杯 A 组首轮比赛即将打响，东道主之一的墨西哥队将在阿兹特克体育场迎战波兰。墨西哥在家门口作战拥有得天独厚的主场优势，历史上他们曾多次在世界杯小组赛阶段爆冷击败强队。波兰队则拥有顶级前锋莱万多夫斯基，他的终结能力是任何防线都需要重点关注的。双方在中场的争夺将决定比赛走势，墨西哥的传控配合与波兰的简洁高效形成鲜明对比。此役两队各有优势，胜负难以预料。",
            PublishDate = DateTime.Parse("2026-06-10"),
            ImageUrl = "",
            Source = "ESPN"
        },
        new News {
            Id = 3,
            Title = "加拿大 vs 沙特阿拉伯 东道主渴望首胜",
            Summary = "A组另一场首轮比赛，加拿大队在多伦多主场对阵沙特阿拉伯，双方力争抢下开局三分。",
            Content = "同为 A 组的加拿大队与沙特阿拉伯队即将在多伦多 BMO 球场展开交锋。加拿大队是本届世界杯三支东道主球队之一，拥有阿方索·戴维斯等效力于欧洲顶级联赛的球员，速度和冲击力是他们的特点。沙特阿拉伯队作为亚洲强队，在 2022 年卡塔尔世界杯上曾爆冷击败阿根廷，展现出极强的战斗力和团队配合。两支球队都希望在首轮比赛拿下三分，为之后的小组出线争取有利位置。",
            PublishDate = DateTime.Parse("2026-06-10"),
            ImageUrl = "",
            Source = "BBC体育"
        },
        new News {
            Id = 4,
            Title = "美英大战即将上演 普利西奇 vs 凯恩",
            Summary = "B 组焦点战即将在纽约大都会人寿体育场上演，美国队迎战英格兰队。",
            Content = "6 月 12 日，纽约大都会人寿体育场将迎来本届世界杯最受瞩目的比赛之一。美国队的普利西奇将面对英格兰队长凯恩。双方最近一次交锋是在 2022 年卡塔尔世界杯上，当时两队 0-0 握手言和。英格兰队阵容齐整，拥有凯恩、萨卡、贝林厄姆等一众球星；而美国队则在普利西奇、雷纳的带领下希望能够在主场创造惊喜。",
            PublishDate = DateTime.Parse("2026-06-12"),
            ImageUrl = "",
            Source = "天空体育"
        },
        new News {
            Id = 5,
            Title = "阿根廷法国提前相遇 C 组上演死亡之组",
            Summary = "卫冕冠军阿根廷与上届亚军法国在小组赛阶段提前相遇，这场比赛将决定 C 组的出线形势。",
            Content = "梅西领衔的阿根廷队将在迈阿密迎战姆巴佩带领的法国队，这场比赛被媒体称为'提前上演的决赛'。两队在 2022 年卡塔尔世界杯决赛中有过精彩对决，当时阿根廷通过点球大战击败法国夺冠。如今两队再次相遇，梅西能否继续带领阿根廷前进？姆巴佩又将率法国队做出怎样的回应？让我们拭目以待。",
            PublishDate = DateTime.Parse("2026-06-12"),
            ImageUrl = "",
            Source = "马卡报"
        },
        new News {
            Id = 6,
            Title = "巴西西班牙强强对话 D组竞争白热化",
            Summary = "巴西与西班牙的经典对决将在达拉斯AT&T体育场上演，南美劲旅对阵欧洲豪门。",
            Content = "D组首轮焦点战，五星巴西对阵西班牙。巴西队阵容豪华，维尼修斯、罗德里戈、拉菲尼亚组成的攻击线令人胆寒；而西班牙队则以年轻球员为主，加维、佩德里、亚马尔等新星状态正佳。两队历史交锋多次上演经典对决，本场比赛注定精彩。同组的德国和摩洛哥也在虎视眈眈，D组堪称本届世界杯的又一个死亡之组。",
            PublishDate = DateTime.Parse("2026-06-13"),
            ImageUrl = "",
            Source = "阿斯报"
        },
        new News {
            Id = 7,
            Title = "日本对阵塞内加尔 亚洲蓝武士能否击退非洲劲旅",
            Summary = "B组次场比赛将在洛杉矶 SoFi 体育场展开，日本队迎战塞内加尔。",
            Content = "6月12日，洛杉矶 SoFi 体育场，日本队将迎来本届世界杯的首个对手塞内加尔。由三笘薫、久保建英领衔的日本队，在战术素养和传控能力上享誉足坛；而塞内加尔则拥有马内、库利巴利等顶级球星，身体素质强悍，反击速度极快。两队曾在 2018 年俄罗斯世界杯上有过交手，当时日本 2-2 战平塞内加尔。此番再度相遇，谁能拿下 B 组的首场胜利？",
            PublishDate = DateTime.Parse("2026-06-12"),
            ImageUrl = "",
            Source = "NHK体育"
        },
        new News {
            Id = 8,
            Title = "澳大利亚迎战突尼斯 袋鼠军团期待拿分",
            Summary = "C组另一场比赛在堪萨斯城进行，澳大利亚对阵北非劲旅突尼斯。",
            Content = "6月13日，堪萨斯城箭头球场，澳大利亚队将迎战突尼斯。作为亚足联的代表，澳大利亚队作风硬朗，身体对抗出色，定位球是他们的得分利器。突尼斯队则以严密的防守和快速反击见长，近年来在非洲杯和世界杯上表现稳定。两队都希望在这场比赛中拿下三分，为小组出线争取有利位置。",
            PublishDate = DateTime.Parse("2026-06-13"),
            ImageUrl = "",
            Source = "福克斯体育"
        },
        new News {
            Id = 9,
            Title = "德国摩洛哥碰撞 日耳曼战车能否重回巅峰",
            Summary = "D组另一场首轮对决在奥兰多上演，四届冠军德国队对阵非洲劲旅摩洛哥。",
            Content = "6月14日，奥兰多露营世界球场，德国队迎来小组赛首战对手摩洛哥。德国队在 2022 年卡塔尔世界杯小组赛阶段惨遭淘汰后，经历了阵容换血，年轻一代如穆西亚拉、维尔茨等已经挑起大梁。摩洛哥队则是上届世界杯的最大黑马，一路杀入四强创造了非洲足球历史。本场比赛，摩洛哥希望延续黑马本色，而德国则期望用一场胜利宣告王者归来。",
            PublishDate = DateTime.Parse("2026-06-14"),
            ImageUrl = "",
            Source = "踢球者"
        },
        new News {
            Id = 10,
            Title = "美国对阵日本 流明球场迎接技术流对决",
            Summary = "B组第二轮，美国队坐镇西雅图主场迎战日本队，普利西奇对阵三笘薫。",
            Content = "6月16日，西雅图流明球场，东道主之一的美国队将迎来小组赛第二个对手日本队。美国队在主场作战，占据天时地利人和，普利西奇、雷纳、麦肯尼等效力于欧洲顶级联赛的球员状态正佳。日本队则以细腻的脚下技术和出色的团队配合著称，主教练森保一的战术部署屡屡让人眼前一亮。这场对决，是美式冲击和日式传控的精彩碰撞。",
            PublishDate = DateTime.Parse("2026-06-15"),
            ImageUrl = "",
            Source = "Yahoo体育"
        },
        new News {
            Id = 11,
            Title = "阿根廷迎战澳大利亚 休斯顿NRG见证梅西登场",
            Summary = "C组第二轮阿根廷对阵澳大利亚，梅西率队冲击小组两连胜。",
            Content = "6月17日，休斯顿NRG体育场，卫冕冠军阿根廷队迎来小组赛第二个对手澳大利亚。首轮对法国大战消耗巨大，阿根廷需要尽快调整状态，梅西依旧是球队最可信赖的核心。澳大利亚在上届世界杯中曾经 1-2 惜败阿根廷，此次再度交手，袋鼠军团希望能够制造惊喜。阿根廷只要拿下本场比赛就将一只脚迈进淘汰赛。",
            PublishDate = DateTime.Parse("2026-06-16"),
            ImageUrl = "",
            Source = "TyC体育"
        },
        new News {
            Id = 12,
            Title = "巴西德国经典对决 联邦快递球场再续恩怨",
            Summary = "D组第二轮迎来世界杯历史上最经典的对阵之一，巴西对阵德国。",
            Content = "6月18日，华盛顿联邦快递球场，五星巴西迎战四星德国，这场比赛注定将吸引全世界的目光。两队是世界杯历史上夺冠次数最多的两支球队，加起来共有 9 座大力神杯。10 年前的巴西世界杯半决赛，德国 7-1 大胜巴西成为经典一幕，如今新一代的巴西球员渴望复仇。维尼修斯、罗德里戈领衔的桑巴军团对阵穆西亚拉、哈弗茨领衔的日耳曼战车，这场比赛绝对不缺看点。",
            PublishDate = DateTime.Parse("2026-06-17"),
            ImageUrl = "",
            Source = "环球体育"
        },
        new News {
            Id = 13,
            Title = "C罗第五次出征世界杯 葡萄牙阵容齐整力争佳绩",
            Summary = "39 岁的 C 罗第五次站上世界杯舞台，外界普遍关注他能否带领葡萄牙走得更远。",
            Content = "6 月的美利坚，39 岁的克里斯蒂亚诺·罗纳尔多即将迎来个人第五届世界杯。从 2006 年德国世界杯初出茅庐的年轻边锋，到如今五届金球奖得主，C罗的职业生涯充满传奇色彩。葡萄牙队近年来新一代球员迅速成长，B 费、B 席、莱奥等球星在欧洲豪门均有出色表现，老中青三代结合的阵容配置较为齐整。本届世界杯葡萄牙被分在竞争激烈的小组中，球队整体实力均衡，外界看好他们至少能进入淘汰赛阶段。",
            PublishDate = DateTime.Parse("2026-06-10"),
            ImageUrl = "",
            Source = "Record 纪录报"
        },
        new News {
            Id = 14,
            Title = "莫德里奇再度出征 克罗地亚铁血军团值得期待",
            Summary = "40 岁的卢卡·莫德里奇迎来个人第五届世界杯，克罗地亚黄金一代再战世界舞台。",
            Content = "40 岁的卢卡·莫德里奇将再度带领克罗地亚征战世界杯。2018 年俄罗斯世界杯上，莫德里奇带领克罗地亚一路杀入决赛，创造了克罗地亚足球历史最佳战绩，并一举拿下当年的金球奖。2022 年卡塔尔世界杯，他又率队拿下季军。如今 40 岁的他依旧保持着出色的竞技状态。克罗地亚阵中还有布罗佐维奇、科瓦契奇等经验丰富的名将，这支以铁血防守和团队韧性著称的格子军团，永远是任何对手都不可小觑的强硬对手。",
            PublishDate = DateTime.Parse("2026-06-10"),
            ImageUrl = "",
            Source = "Sportske Novosti"
        },
    };

    public List<Team> GetTeams() => _teams;

    public List<Match> GetMatches() => _matches.OrderBy(m => m.MatchDate).ToList();

    public List<News> GetNews() => _news.OrderByDescending(n => n.PublishDate).ToList();

    public Dictionary<string, List<Team>> GetStandings()
    {
        var standings = new Dictionary<string, List<Team>>();

        foreach (var team in _teams)
        {
            if (!standings.ContainsKey(team.Group))
            {
                standings[team.Group] = new List<Team>();
            }

            var teamStats = new Team
            {
                Id = team.Id,
                Name = team.Name,
                Country = team.Country,
                Group = team.Group,
                FlagUrl = team.FlagUrl,
                Played = 0,
                Won = 0,
                Drawn = 0,
                Lost = 0,
                GoalsFor = 0,
                GoalsAgainst = 0
            };

            foreach (var match in _matches.Where(m => m.IsFinished))
            {
                if (match.HomeTeam.Name == team.Name)
                {
                    teamStats.Played++;
                    teamStats.GoalsFor += match.HomeScore ?? 0;
                    teamStats.GoalsAgainst += match.AwayScore ?? 0;
                    if (match.HomeScore > match.AwayScore) teamStats.Won++;
                    else if (match.HomeScore == match.AwayScore) teamStats.Drawn++;
                    else teamStats.Lost++;
                }
                else if (match.AwayTeam.Name == team.Name)
                {
                    teamStats.Played++;
                    teamStats.GoalsFor += match.AwayScore ?? 0;
                    teamStats.GoalsAgainst += match.HomeScore ?? 0;
                    if (match.AwayScore > match.HomeScore) teamStats.Won++;
                    else if (match.AwayScore == match.HomeScore) teamStats.Drawn++;
                    else teamStats.Lost++;
                }
            }

            standings[team.Group].Add(teamStats);
        }

        foreach (var group in standings.Keys.ToList())
        {
            standings[group] = standings[group]
                .OrderByDescending(t => t.Points)
                .ThenByDescending(t => t.GoalDifference)
                .ThenByDescending(t => t.GoalsFor)
                .ThenBy(t => t.Name)
                .ToList();
        }

        return standings;
    }

    public List<Stadium> GetStadiums()
    {
        return new List<Stadium>
        {
            new Stadium { Id = 1, Name = "阿兹特克体育场", City = "墨西哥城", Country = "墨西哥", CountryFlag = "🇲🇽", Capacity = 87523, MatchesHosted = 2 },
            new Stadium { Id = 2, Name = "BMO 球场", City = "多伦多", Country = "加拿大", CountryFlag = "🇨🇦", Capacity = 45736, MatchesHosted = 2 },
            new Stadium { Id = 3, Name = "大都会人寿体育场", City = "纽约", Country = "美国", CountryFlag = "🇺🇸", Capacity = 82500, MatchesHosted = 2 },
            new Stadium { Id = 4, Name = "SoFi 体育场", City = "洛杉矶", Country = "美国", CountryFlag = "🇺🇸", Capacity = 70240, MatchesHosted = 2 },
            new Stadium { Id = 5, Name = "迈阿密硬石体育场", City = "迈阿密", Country = "美国", CountryFlag = "🇺🇸", Capacity = 65326, MatchesHosted = 2 },
            new Stadium { Id = 6, Name = "AT&T 体育场", City = "达拉斯", Country = "美国", CountryFlag = "🇺🇸", Capacity = 80000, MatchesHosted = 2 },
            new Stadium { Id = 7, Name = "箭头球场", City = "堪萨斯城", Country = "美国", CountryFlag = "🇺🇸", Capacity = 76416, MatchesHosted = 2 },
            new Stadium { Id = 8, Name = "NRG 体育场", City = "休斯顿", Country = "美国", CountryFlag = "🇺🇸", Capacity = 72220, MatchesHosted = 2 },
            new Stadium { Id = 9, Name = "流明球场", City = "西雅图", Country = "美国", CountryFlag = "🇺🇸", Capacity = 69000, MatchesHosted = 2 },
            new Stadium { Id = 10, Name = "联邦快递球场", City = "华盛顿", Country = "美国", CountryFlag = "🇺🇸", Capacity = 62000, MatchesHosted = 2 },
            new Stadium { Id = 11, Name = "梅赛德斯-奔驰体育场", City = "亚特兰大", Country = "美国", CountryFlag = "🇺🇸", Capacity = 71000, MatchesHosted = 2 },
            new Stadium { Id = 12, Name = "吉列体育场", City = "波士顿", Country = "美国", CountryFlag = "🇺🇸", Capacity = 65878, MatchesHosted = 2 },
            new Stadium { Id = 13, Name = "李维斯体育场", City = "旧金山", Country = "美国", CountryFlag = "🇺🇸", Capacity = 68500, MatchesHosted = 2 },
            new Stadium { Id = 14, Name = "林肯金融球场", City = "费城", Country = "美国", CountryFlag = "🇺🇸", Capacity = 67594, MatchesHosted = 2 },
            new Stadium { Id = 15, Name = "BC Place", City = "温哥华", Country = "加拿大", CountryFlag = "🇨🇦", Capacity = 54500, MatchesHosted = 2 },
            new Stadium { Id = 16, Name = "露营世界体育场", City = "奥兰多", Country = "美国", CountryFlag = "🇺🇸", Capacity = 60219, MatchesHosted = 2 }
        };
    }

    public List<Player> GetTopScorerCandidates()
    {
        return new List<Player>
        {
            new Player { Id = 1, Name = "姆巴佩", Age = 27, Position = "前锋", NationalTeam = "法国", NationalFlag = "🇫🇷", Club = "皇家马德里", InternationalGoals = 52, WorldCupGoals = 12, PredictedGoals = 7, MarketValueM = 180 },
            new Player { Id = 2, Name = "哈兰德", Age = 25, Position = "前锋", NationalTeam = "挪威", NationalFlag = "🇳🇴", Club = "曼彻斯特城", InternationalGoals = 38, WorldCupGoals = 0, PredictedGoals = 6, MarketValueM = 200 },
            new Player { Id = 3, Name = "维尼修斯·儒尼奥尔", Age = 25, Position = "边锋", NationalTeam = "巴西", NationalFlag = "🇧🇷", Club = "皇家马德里", InternationalGoals = 28, WorldCupGoals = 2, PredictedGoals = 5, MarketValueM = 180 },
            new Player { Id = 4, Name = "哈里·凯恩", Age = 32, Position = "中锋", NationalTeam = "英格兰", NationalFlag = "🇬🇧", Club = "拜仁慕尼黑", InternationalGoals = 66, WorldCupGoals = 8, PredictedGoals = 6, MarketValueM = 100 },
            new Player { Id = 5, Name = "梅西", Age = 38, Position = "前腰/边锋", NationalTeam = "阿根廷", NationalFlag = "🇦🇷", Club = "迈阿密国际", InternationalGoals = 112, WorldCupGoals = 13, PredictedGoals = 4, MarketValueM = 35 },
            new Player { Id = 6, Name = "克里斯蒂亚诺·罗纳尔多", Age = 39, Position = "前锋", NationalTeam = "葡萄牙", NationalFlag = "🇵🇹", Club = "利雅得胜利", InternationalGoals = 138, WorldCupGoals = 8, PredictedGoals = 3, MarketValueM = 15 },
            new Player { Id = 7, Name = "罗德里戈", Age = 25, Position = "边锋", NationalTeam = "巴西", NationalFlag = "🇧🇷", Club = "皇家马德里", InternationalGoals = 20, WorldCupGoals = 2, PredictedGoals = 4, MarketValueM = 120 },
            new Player { Id = 8, Name = "劳塔罗·马丁内斯", Age = 28, Position = "前锋", NationalTeam = "阿根廷", NationalFlag = "🇦🇷", Club = "国际米兰", InternationalGoals = 30, WorldCupGoals = 2, PredictedGoals = 4, MarketValueM = 110 },
            new Player { Id = 9, Name = "布卡约·萨卡", Age = 24, Position = "边锋", NationalTeam = "英格兰", NationalFlag = "🇬🇧", Club = "阿森纳", InternationalGoals = 22, WorldCupGoals = 3, PredictedGoals = 4, MarketValueM = 130 },
            new Player { Id = 10, Name = "莱万多夫斯基", Age = 37, Position = "中锋", NationalTeam = "波兰", NationalFlag = "🇵🇱", Club = "巴塞罗那", InternationalGoals = 84, WorldCupGoals = 2, PredictedGoals = 3, MarketValueM = 25 },
            new Player { Id = 11, Name = "三笘薫", Age = 28, Position = "边锋", NationalTeam = "日本", NationalFlag = "🇯🇵", Club = "布莱顿", InternationalGoals = 18, WorldCupGoals = 1, PredictedGoals = 3, MarketValueM = 70 },
            new Player { Id = 12, Name = "普利西奇", Age = 27, Position = "边锋", NationalTeam = "美国", NationalFlag = "🇺🇸", Club = "AC 米兰", InternationalGoals = 30, WorldCupGoals = 1, PredictedGoals = 3, MarketValueM = 60 },
            new Player { Id = 13, Name = "莫德里奇", Age = 40, Position = "中场", NationalTeam = "克罗地亚", NationalFlag = "🇭🇷", Club = "皇家马德里", InternationalGoals = 28, WorldCupGoals = 3, PredictedGoals = 2, MarketValueM = 10 },
            new Player { Id = 14, Name = "阿方索·戴维斯", Age = 25, Position = "左边卫", NationalTeam = "加拿大", NationalFlag = "🇨🇦", Club = "拜仁慕尼黑", InternationalGoals = 15, WorldCupGoals = 0, PredictedGoals = 2, MarketValueM = 70 }
        };
    }

    public List<PowerRanking> GetPowerRankings()
    {
        var list = new List<PowerRanking>
        {
            new PowerRanking { TeamName = "阿根廷", FlagUrl = "🇦🇷", Group = "C", FifaRanking = 1, AttackScore = 92, MidfieldScore = 90, DefenseScore = 84, GoalkeeperScore = 88, WinProbability = 18.5m, StarPlayer = "梅西", BestFinish = "冠军（1978、1986、2022）" },
            new PowerRanking { TeamName = "法国", FlagUrl = "🇫🇷", Group = "C", FifaRanking = 2, AttackScore = 95, MidfieldScore = 88, DefenseScore = 85, GoalkeeperScore = 85, WinProbability = 16.0m, StarPlayer = "姆巴佩", BestFinish = "冠军（1998、2018）" },
            new PowerRanking { TeamName = "巴西", FlagUrl = "🇧🇷", Group = "D", FifaRanking = 5, AttackScore = 94, MidfieldScore = 85, DefenseScore = 86, GoalkeeperScore = 82, WinProbability = 14.0m, StarPlayer = "维尼修斯", BestFinish = "冠军（1958、1962、1970、1994、2002）" },
            new PowerRanking { TeamName = "英格兰", FlagUrl = "🇬🇧", Group = "B", FifaRanking = 3, AttackScore = 90, MidfieldScore = 89, DefenseScore = 87, GoalkeeperScore = 86, WinProbability = 12.0m, StarPlayer = "凯恩", BestFinish = "冠军（1966）" },
            new PowerRanking { TeamName = "西班牙", FlagUrl = "🇪🇸", Group = "D", FifaRanking = 6, AttackScore = 86, MidfieldScore = 93, DefenseScore = 86, GoalkeeperScore = 85, WinProbability = 9.0m, StarPlayer = "亚马尔", BestFinish = "冠军（2010）" },
            new PowerRanking { TeamName = "德国", FlagUrl = "🇩🇪", Group = "D", FifaRanking = 9, AttackScore = 87, MidfieldScore = 90, DefenseScore = 86, GoalkeeperScore = 89, WinProbability = 8.0m, StarPlayer = "穆西亚拉", BestFinish = "冠军（1954、1974、1990、2014）" },
            new PowerRanking { TeamName = "葡萄牙", FlagUrl = "🇵🇹", Group = "模拟外卡", FifaRanking = 8, AttackScore = 88, MidfieldScore = 87, DefenseScore = 82, GoalkeeperScore = 80, WinProbability = 5.5m, StarPlayer = "C罗", BestFinish = "季军（1966）" },
            new PowerRanking { TeamName = "克罗地亚", FlagUrl = "🇭🇷", Group = "模拟外卡", FifaRanking = 10, AttackScore = 80, MidfieldScore = 91, DefenseScore = 85, GoalkeeperScore = 85, WinProbability = 4.0m, StarPlayer = "莫德里奇", BestFinish = "亚军（2018）、季军（2022）" },
            new PowerRanking { TeamName = "美国", FlagUrl = "🇺🇸", Group = "B", FifaRanking = 13, AttackScore = 80, MidfieldScore = 82, DefenseScore = 78, GoalkeeperScore = 80, WinProbability = 3.0m, StarPlayer = "普利西奇", BestFinish = "季军（1930）" },
            new PowerRanking { TeamName = "日本", FlagUrl = "🇯🇵", Group = "B", FifaRanking = 15, AttackScore = 82, MidfieldScore = 83, DefenseScore = 79, GoalkeeperScore = 78, WinProbability = 2.5m, StarPlayer = "三笘薫", BestFinish = "十六强（2002、2010、2018、2022）" },
            new PowerRanking { TeamName = "波兰", FlagUrl = "🇵🇱", Group = "A", FifaRanking = 21, AttackScore = 82, MidfieldScore = 74, DefenseScore = 76, GoalkeeperScore = 80, WinProbability = 1.5m, StarPlayer = "莱万多夫斯基", BestFinish = "季军（1974、1982）" },
            new PowerRanking { TeamName = "塞内加尔", FlagUrl = "🇸🇳", Group = "B", FifaRanking = 18, AttackScore = 80, MidfieldScore = 78, DefenseScore = 76, GoalkeeperScore = 76, WinProbability = 1.5m, StarPlayer = "马内", BestFinish = "八强（2002）" },
            new PowerRanking { TeamName = "摩洛哥", FlagUrl = "🇲🇦", Group = "D", FifaRanking = 12, AttackScore = 76, MidfieldScore = 79, DefenseScore = 88, GoalkeeperScore = 86, WinProbability = 2.5m, StarPlayer = "阿什拉夫", BestFinish = "四强（2022）" },
            new PowerRanking { TeamName = "墨西哥", FlagUrl = "🇲🇽", Group = "A", FifaRanking = 14, AttackScore = 76, MidfieldScore = 78, DefenseScore = 80, GoalkeeperScore = 82, WinProbability = 1.5m, StarPlayer = "洛萨诺", BestFinish = "八强（1970、1986）" },
            new PowerRanking { TeamName = "加拿大", FlagUrl = "🇨🇦", Group = "A", FifaRanking = 38, AttackScore = 74, MidfieldScore = 70, DefenseScore = 72, GoalkeeperScore = 75, WinProbability = 0.5m, StarPlayer = "阿方索·戴维斯", BestFinish = "小组赛（1986、2022）" },
            new PowerRanking { TeamName = "沙特阿拉伯", FlagUrl = "🇸🇦", Group = "A", FifaRanking = 47, AttackScore = 70, MidfieldScore = 68, DefenseScore = 70, GoalkeeperScore = 72, WinProbability = 0.5m, StarPlayer = "阿尔-达瓦萨里", BestFinish = "十六强（1994）" },
            new PowerRanking { TeamName = "澳大利亚", FlagUrl = "🇦🇺", Group = "C", FifaRanking = 27, AttackScore = 72, MidfieldScore = 70, DefenseScore = 73, GoalkeeperScore = 76, WinProbability = 0.8m, StarPlayer = "苏塔", BestFinish = "十六强（2006、2022）" },
            new PowerRanking { TeamName = "突尼斯", FlagUrl = "🇹🇳", Group = "C", FifaRanking = 30, AttackScore = 70, MidfieldScore = 70, DefenseScore = 74, GoalkeeperScore = 74, WinProbability = 0.7m, StarPlayer = "哈兹里", BestFinish = "小组赛（多次）" }
        };

        foreach (var item in list)
        {
            item.TotalScore = item.AttackScore + item.MidfieldScore + item.DefenseScore + item.GoalkeeperScore;
        }

        var ordered = list.OrderByDescending(r => r.TotalScore).ToList();
        for (int i = 0; i < ordered.Count; i++)
        {
            ordered[i].Rank = i + 1;
        }
        return ordered;
    }
}
