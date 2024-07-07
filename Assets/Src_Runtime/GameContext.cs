// 上下文: 游戏上下文, 用于存储游戏中的数据
public class GameContext {

    // Managers
    public TemplateManager templateManager;
    // AssetManager
    // UIManger
    // InputManger

    // Entity / Repo
    public InputEntity input;
    public RoleRepo roleRepo;

    // Service
    public IDService idService;

    // ......

    public GameContext() {

        input = new InputEntity();

        templateManager = new TemplateManager();

        roleRepo = new RoleRepo();

        idService = new IDService();
    }

}