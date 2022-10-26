using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace wikiprettya.Models;

public partial class dbContext : DbContext
{
    private  IConfiguration _configuration {get;set;}
    public dbContext( IConfiguration configuration)
    {
        _configuration = configuration ;
    }

    public dbContext(DbContextOptions<dbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }
    public virtual DbSet<Archive> Archives { get; set; }
    public virtual DbSet<BotPassword> BotPasswords { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Categorylink> Categorylinks { get; set; }
    public virtual DbSet<ChangeTag> ChangeTags { get; set; }
    public virtual DbSet<ChangeTagDef> ChangeTagDefs { get; set; }
    public virtual DbSet<Comment> Comments { get; set; }
    public virtual DbSet<Content> Contents { get; set; }
    public virtual DbSet<ContentModel> ContentModels { get; set; }
    public virtual DbSet<Externallink> Externallinks { get; set; }
    public virtual DbSet<Filearchive> Filearchives { get; set; }
    public virtual DbSet<Image> Images { get; set; }
    public virtual DbSet<Imagelink> Imagelinks { get; set; }
    public virtual DbSet<Interwiki> Interwikis { get; set; }
    public virtual DbSet<IpChange> IpChanges { get; set; }
    public virtual DbSet<Ipblock> Ipblocks { get; set; }
    public virtual DbSet<IpblocksRestriction> IpblocksRestrictions { get; set; }
    public virtual DbSet<Iwlink> Iwlinks { get; set; }
    public virtual DbSet<Job> Jobs { get; set; }
    public virtual DbSet<L10nCache> L10nCaches { get; set; }
    public virtual DbSet<Langlink> Langlinks { get; set; }
    public virtual DbSet<Linktarget> Linktargets { get; set; }
    public virtual DbSet<LogSearch> LogSearches { get; set; }
    public virtual DbSet<Logging> Loggings { get; set; }
    public virtual DbSet<ModuleDep> ModuleDeps { get; set; }
    public virtual DbSet<Objectcache> Objectcaches { get; set; }
    public virtual DbSet<Oldimage> Oldimages { get; set; }
    public virtual DbSet<Page> Pages { get; set; }
    public virtual DbSet<PageProp> PageProps { get; set; }
    public virtual DbSet<PageRestriction> PageRestrictions { get; set; }
    public virtual DbSet<Pagelink> Pagelinks { get; set; }
    public virtual DbSet<ProtectedTitle> ProtectedTitles { get; set; }
    public virtual DbSet<Querycache> Querycaches { get; set; }
    public virtual DbSet<QuerycacheInfo> QuerycacheInfos { get; set; }
    public virtual DbSet<Querycachetwo> Querycachetwos { get; set; }
    public virtual DbSet<Recentchange> Recentchanges { get; set; }
    public virtual DbSet<Redirect> Redirects { get; set; }
    public virtual DbSet<Revision> Revisions { get; set; }
    public virtual DbSet<RevisionCommentTemp> RevisionCommentTemps { get; set; }
    public virtual DbSet<Searchindex> Searchindices { get; set; }
    public virtual DbSet<Site> Sites { get; set; }
    public virtual DbSet<SiteIdentifier> SiteIdentifiers { get; set; }
    public virtual DbSet<SiteStat> SiteStats { get; set; }
    public virtual DbSet<Slot> Slots { get; set; }
    public virtual DbSet<SlotRole> SlotRoles { get; set; }
    public virtual DbSet<Templatelink> Templatelinks { get; set; }
    public virtual DbSet<Text> Texts { get; set; }
    public virtual DbSet<Updatelog> Updatelogs { get; set; }
    public virtual DbSet<Uploadstash> Uploadstashes { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<UserAutocreateSerial> UserAutocreateSerials { get; set; }
    public virtual DbSet<UserFormerGroup> UserFormerGroups { get; set; }
    public virtual DbSet<UserGroup> UserGroups { get; set; }
    public virtual DbSet<UserNewtalk> UserNewtalks { get; set; }
    public virtual DbSet<UserProperty> UserProperties { get; set; }
    public virtual DbSet<Watchlist> Watchlists { get; set; }
    public virtual DbSet<WatchlistExpiry> WatchlistExpiries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseMySql( _configuration["ConnectionString"], Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Actor>(entity =>
        {
            entity.ToTable("actor");

            entity.HasIndex(e => e.ActorName, "actor_name")
                .IsUnique();

            entity.HasIndex(e => e.ActorUser, "actor_user")
                .IsUnique();

            entity.Property(e => e.ActorId).HasColumnName("actor_id");

            entity.Property(e => e.ActorName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("actor_name");

            entity.Property(e => e.ActorUser).HasColumnName("actor_user");
        });

        modelBuilder.Entity<Archive>(entity =>
        {
            entity.HasKey(e => e.ArId)
                .HasName("PRIMARY");

            entity.ToTable("archive");

            entity.HasIndex(e => new { e.ArActor, e.ArTimestamp }, "ar_actor_timestamp");

            entity.HasIndex(e => new { e.ArNamespace, e.ArTitle, e.ArTimestamp }, "ar_name_title_timestamp");

            entity.HasIndex(e => e.ArRevId, "ar_revid_uniq")
                .IsUnique();

            entity.Property(e => e.ArId).HasColumnName("ar_id");

            entity.Property(e => e.ArActor).HasColumnName("ar_actor");

            entity.Property(e => e.ArCommentId).HasColumnName("ar_comment_id");

            entity.Property(e => e.ArDeleted).HasColumnName("ar_deleted");

            entity.Property(e => e.ArLen).HasColumnName("ar_len");

            entity.Property(e => e.ArMinorEdit).HasColumnName("ar_minor_edit");

            entity.Property(e => e.ArNamespace).HasColumnName("ar_namespace");

            entity.Property(e => e.ArPageId).HasColumnName("ar_page_id");

            entity.Property(e => e.ArParentId).HasColumnName("ar_parent_id");

            entity.Property(e => e.ArRevId).HasColumnName("ar_rev_id");

            entity.Property(e => e.ArSha1)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("ar_sha1")
                .HasDefaultValueSql("''");

            entity.Property(e => e.ArTimestamp)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("ar_timestamp")
                .IsFixedLength();

            entity.Property(e => e.ArTitle)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("ar_title")
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<BotPassword>(entity =>
        {
            entity.HasKey(e => new { e.BpUser, e.BpAppId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("bot_passwords");

            entity.Property(e => e.BpUser).HasColumnName("bp_user");

            entity.Property(e => e.BpAppId)
                .HasMaxLength(32)
                .HasColumnName("bp_app_id");

            entity.Property(e => e.BpGrants)
                .IsRequired()
                .HasColumnType("blob")
                .HasColumnName("bp_grants");

            entity.Property(e => e.BpPassword)
                .IsRequired()
                .HasColumnType("tinyblob")
                .HasColumnName("bp_password");

            entity.Property(e => e.BpRestrictions)
                .IsRequired()
                .HasColumnType("blob")
                .HasColumnName("bp_restrictions");

            entity.Property(e => e.BpToken)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("bp_token")
                .HasDefaultValueSql("'0x'")
                .IsFixedLength();
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CatId)
                .HasName("PRIMARY");

            entity.ToTable("category");

            entity.HasIndex(e => e.CatPages, "cat_pages");

            entity.HasIndex(e => e.CatTitle, "cat_title")
                .IsUnique();

            entity.Property(e => e.CatId).HasColumnName("cat_id");

            entity.Property(e => e.CatFiles).HasColumnName("cat_files");

            entity.Property(e => e.CatPages).HasColumnName("cat_pages");

            entity.Property(e => e.CatSubcats).HasColumnName("cat_subcats");

            entity.Property(e => e.CatTitle)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("cat_title");
        });

        modelBuilder.Entity<Categorylink>(entity =>
        {
            entity.HasKey(e => new { e.ClFrom, e.ClTo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("categorylinks");

            entity.HasIndex(e => new { e.ClCollation, e.ClTo, e.ClType, e.ClFrom }, "cl_collation_ext");

            entity.HasIndex(e => new { e.ClTo, e.ClType, e.ClSortkey, e.ClFrom }, "cl_sortkey");

            entity.HasIndex(e => new { e.ClTo, e.ClTimestamp }, "cl_timestamp");

            entity.Property(e => e.ClFrom).HasColumnName("cl_from");

            entity.Property(e => e.ClTo)
                .HasMaxLength(255)
                .HasColumnName("cl_to")
                .HasDefaultValueSql("''");

            entity.Property(e => e.ClCollation)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("cl_collation")
                .HasDefaultValueSql("''");

            entity.Property(e => e.ClSortkey)
                .IsRequired()
                .HasMaxLength(230)
                .HasColumnName("cl_sortkey")
                .HasDefaultValueSql("''");

            entity.Property(e => e.ClSortkeyPrefix)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("cl_sortkey_prefix")
                .HasDefaultValueSql("''");

            entity.Property(e => e.ClTimestamp)
                .HasColumnType("timestamp")
                .HasColumnName("cl_timestamp");

            entity.Property(e => e.ClType)
                .IsRequired()
                .HasColumnType("enum('page','subcat','file')")
                .HasColumnName("cl_type")
                .HasDefaultValueSql("'page'");
        });

        modelBuilder.Entity<ChangeTag>(entity =>
        {
            entity.HasKey(e => e.CtId)
                .HasName("PRIMARY");

            entity.ToTable("change_tag");

            entity.HasIndex(e => new { e.CtLogId, e.CtTagId }, "ct_log_tag_id")
                .IsUnique();

            entity.HasIndex(e => new { e.CtRcId, e.CtTagId }, "ct_rc_tag_id")
                .IsUnique();

            entity.HasIndex(e => new { e.CtRevId, e.CtTagId }, "ct_rev_tag_id")
                .IsUnique();

            entity.HasIndex(e => new { e.CtTagId, e.CtRcId, e.CtRevId, e.CtLogId }, "ct_tag_id_id");

            entity.Property(e => e.CtId).HasColumnName("ct_id");

            entity.Property(e => e.CtLogId).HasColumnName("ct_log_id");

            entity.Property(e => e.CtParams)
                .HasColumnType("blob")
                .HasColumnName("ct_params");

            entity.Property(e => e.CtRcId).HasColumnName("ct_rc_id");

            entity.Property(e => e.CtRevId).HasColumnName("ct_rev_id");

            entity.Property(e => e.CtTagId).HasColumnName("ct_tag_id");
        });

        modelBuilder.Entity<ChangeTagDef>(entity =>
        {
            entity.HasKey(e => e.CtdId)
                .HasName("PRIMARY");

            entity.ToTable("change_tag_def");

            entity.HasIndex(e => e.CtdCount, "ctd_count");

            entity.HasIndex(e => e.CtdName, "ctd_name")
                .IsUnique();

            entity.HasIndex(e => e.CtdUserDefined, "ctd_user_defined");

            entity.Property(e => e.CtdId).HasColumnName("ctd_id");

            entity.Property(e => e.CtdCount).HasColumnName("ctd_count");

            entity.Property(e => e.CtdName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("ctd_name");

            entity.Property(e => e.CtdUserDefined).HasColumnName("ctd_user_defined");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.ToTable("comment");

            entity.HasIndex(e => e.CommentHash, "comment_hash");

            entity.Property(e => e.CommentId).HasColumnName("comment_id");

            entity.Property(e => e.CommentData)
                .HasColumnType("blob")
                .HasColumnName("comment_data");

            entity.Property(e => e.CommentHash).HasColumnName("comment_hash");

            entity.Property(e => e.CommentText)
                .IsRequired()
                .HasColumnType("blob")
                .HasColumnName("comment_text");
        });

        modelBuilder.Entity<Content>(entity =>
        {
            entity.ToTable("content");

            entity.Property(e => e.ContentId).HasColumnName("content_id");

            entity.Property(e => e.ContentAddress)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("content_address");

            entity.Property(e => e.ContentModel).HasColumnName("content_model");

            entity.Property(e => e.ContentSha1)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("content_sha1");

            entity.Property(e => e.ContentSize).HasColumnName("content_size");
        });

        modelBuilder.Entity<ContentModel>(entity =>
        {
            entity.HasKey(e => e.ModelId)
                .HasName("PRIMARY");

            entity.ToTable("content_models");

            entity.HasIndex(e => e.ModelName, "model_name")
                .IsUnique();

            entity.Property(e => e.ModelId).HasColumnName("model_id");

            entity.Property(e => e.ModelName)
                .IsRequired()
                .HasMaxLength(64)
                .HasColumnName("model_name");
        });

        modelBuilder.Entity<Externallink>(entity =>
        {
            entity.HasKey(e => e.ElId)
                .HasName("PRIMARY");

            entity.ToTable("externallinks");

            entity.HasIndex(e => e.ElFrom, "el_from");

            entity.HasIndex(e => new { e.ElFrom, e.ElIndex60, e.ElId }, "el_from_index_60");

            entity.HasIndex(e => e.ElIndex, "el_index")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 60 });

            entity.HasIndex(e => new { e.ElIndex60, e.ElId }, "el_index_60");

            entity.HasIndex(e => new { e.ElTo, e.ElFrom }, "el_to")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 60, 0 });

            entity.HasIndex(e => new { e.ElToDomainIndex, e.ElToPath }, "el_to_domain_index_to_path")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 60 });

            entity.Property(e => e.ElId).HasColumnName("el_id");

            entity.Property(e => e.ElFrom).HasColumnName("el_from");

            entity.Property(e => e.ElIndex)
                .IsRequired()
                .HasColumnType("blob")
                .HasColumnName("el_index");

            entity.Property(e => e.ElIndex60)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("el_index_60");

            entity.Property(e => e.ElTo)
                .IsRequired()
                .HasColumnType("blob")
                .HasColumnName("el_to");

            entity.Property(e => e.ElToDomainIndex)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("el_to_domain_index")
                .HasDefaultValueSql("''");

            entity.Property(e => e.ElToPath)
                .HasColumnType("blob")
                .HasColumnName("el_to_path");
        });

        modelBuilder.Entity<Filearchive>(entity =>
        {
            entity.HasKey(e => e.FaId)
                .HasName("PRIMARY");

            entity.ToTable("filearchive");

            entity.HasIndex(e => new { e.FaActor, e.FaTimestamp }, "fa_actor_timestamp");

            entity.HasIndex(e => e.FaDeletedTimestamp, "fa_deleted_timestamp");

            entity.HasIndex(e => new { e.FaName, e.FaTimestamp }, "fa_name");

            entity.HasIndex(e => e.FaSha1, "fa_sha1")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 10 });

            entity.HasIndex(e => new { e.FaStorageGroup, e.FaStorageKey }, "fa_storage_group");

            entity.Property(e => e.FaId).HasColumnName("fa_id");

            entity.Property(e => e.FaActor).HasColumnName("fa_actor");

            entity.Property(e => e.FaArchiveName)
                .HasMaxLength(255)
                .HasColumnName("fa_archive_name")
                .HasDefaultValueSql("''");

            entity.Property(e => e.FaBits)
                .HasColumnName("fa_bits")
                .HasDefaultValueSql("'0'");

            entity.Property(e => e.FaDeleted).HasColumnName("fa_deleted");

            entity.Property(e => e.FaDeletedReasonId).HasColumnName("fa_deleted_reason_id");

            entity.Property(e => e.FaDeletedTimestamp)
                .HasMaxLength(14)
                .HasColumnName("fa_deleted_timestamp")
                .IsFixedLength();

            entity.Property(e => e.FaDeletedUser).HasColumnName("fa_deleted_user");

            entity.Property(e => e.FaDescriptionId).HasColumnName("fa_description_id");

            entity.Property(e => e.FaHeight)
                .HasColumnName("fa_height")
                .HasDefaultValueSql("'0'");

            entity.Property(e => e.FaMajorMime)
                .HasColumnType("enum('unknown','application','audio','image','text','video','message','model','multipart','chemical')")
                .HasColumnName("fa_major_mime")
                .HasDefaultValueSql("'unknown'");

            entity.Property(e => e.FaMediaType)
                .HasColumnType("enum('UNKNOWN','BITMAP','DRAWING','AUDIO','VIDEO','MULTIMEDIA','OFFICE','TEXT','EXECUTABLE','ARCHIVE','3D')")
                .HasColumnName("fa_media_type");

            entity.Property(e => e.FaMetadata)
                .HasColumnType("mediumblob")
                .HasColumnName("fa_metadata");

            entity.Property(e => e.FaMinorMime)
                .HasMaxLength(100)
                .HasColumnName("fa_minor_mime")
                .HasDefaultValueSql("'0x756E6B6E6F776E'");

            entity.Property(e => e.FaName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("fa_name")
                .HasDefaultValueSql("''");

            entity.Property(e => e.FaSha1)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("fa_sha1")
                .HasDefaultValueSql("''");

            entity.Property(e => e.FaSize)
                .HasColumnName("fa_size")
                .HasDefaultValueSql("'0'");

            entity.Property(e => e.FaStorageGroup)
                .HasMaxLength(16)
                .HasColumnName("fa_storage_group");

            entity.Property(e => e.FaStorageKey)
                .HasMaxLength(64)
                .HasColumnName("fa_storage_key")
                .HasDefaultValueSql("''");

            entity.Property(e => e.FaTimestamp)
                .HasMaxLength(14)
                .HasColumnName("fa_timestamp")
                .IsFixedLength();

            entity.Property(e => e.FaWidth)
                .HasColumnName("fa_width")
                .HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.ImgName)
                .HasName("PRIMARY");

            entity.ToTable("image");

            entity.HasIndex(e => new { e.ImgActor, e.ImgTimestamp }, "img_actor_timestamp");

            entity.HasIndex(e => new { e.ImgMediaType, e.ImgMajorMime, e.ImgMinorMime }, "img_media_mime");

            entity.HasIndex(e => e.ImgSha1, "img_sha1")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 10 });

            entity.HasIndex(e => e.ImgSize, "img_size");

            entity.HasIndex(e => e.ImgTimestamp, "img_timestamp");

            entity.Property(e => e.ImgName)
                .HasMaxLength(255)
                .HasColumnName("img_name")
                .HasDefaultValueSql("''");

            entity.Property(e => e.ImgActor).HasColumnName("img_actor");

            entity.Property(e => e.ImgBits).HasColumnName("img_bits");

            entity.Property(e => e.ImgDescriptionId).HasColumnName("img_description_id");

            entity.Property(e => e.ImgHeight).HasColumnName("img_height");

            entity.Property(e => e.ImgMajorMime)
                .IsRequired()
                .HasColumnType("enum('unknown','application','audio','image','text','video','message','model','multipart','chemical')")
                .HasColumnName("img_major_mime")
                .HasDefaultValueSql("'unknown'");

            entity.Property(e => e.ImgMediaType)
                .HasColumnType("enum('UNKNOWN','BITMAP','DRAWING','AUDIO','VIDEO','MULTIMEDIA','OFFICE','TEXT','EXECUTABLE','ARCHIVE','3D')")
                .HasColumnName("img_media_type");

            entity.Property(e => e.ImgMetadata)
                .IsRequired()
                .HasColumnType("mediumblob")
                .HasColumnName("img_metadata");

            entity.Property(e => e.ImgMinorMime)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("img_minor_mime")
                .HasDefaultValueSql("'0x756E6B6E6F776E'");

            entity.Property(e => e.ImgSha1)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("img_sha1")
                .HasDefaultValueSql("''");

            entity.Property(e => e.ImgSize).HasColumnName("img_size");

            entity.Property(e => e.ImgTimestamp)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("img_timestamp")
                .IsFixedLength();

            entity.Property(e => e.ImgWidth).HasColumnName("img_width");
        });

        modelBuilder.Entity<Imagelink>(entity =>
        {
            entity.HasKey(e => new { e.IlFrom, e.IlTo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("imagelinks");

            entity.HasIndex(e => new { e.IlFromNamespace, e.IlTo, e.IlFrom }, "il_backlinks_namespace");

            entity.HasIndex(e => new { e.IlTo, e.IlFrom }, "il_to");

            entity.Property(e => e.IlFrom).HasColumnName("il_from");

            entity.Property(e => e.IlTo)
                .HasMaxLength(255)
                .HasColumnName("il_to")
                .HasDefaultValueSql("''");

            entity.Property(e => e.IlFromNamespace).HasColumnName("il_from_namespace");
        });

        modelBuilder.Entity<Interwiki>(entity =>
        {
            entity.HasKey(e => e.IwPrefix)
                .HasName("PRIMARY");

            entity.ToTable("interwiki");

            entity.Property(e => e.IwPrefix)
                .HasMaxLength(32)
                .HasColumnName("iw_prefix");

            entity.Property(e => e.IwApi)
                .IsRequired()
                .HasColumnType("blob")
                .HasColumnName("iw_api");

            entity.Property(e => e.IwLocal).HasColumnName("iw_local");

            entity.Property(e => e.IwTrans).HasColumnName("iw_trans");

            entity.Property(e => e.IwUrl)
                .IsRequired()
                .HasColumnType("blob")
                .HasColumnName("iw_url");

            entity.Property(e => e.IwWikiid)
                .IsRequired()
                .HasMaxLength(64)
                .HasColumnName("iw_wikiid");
        });

        modelBuilder.Entity<IpChange>(entity =>
        {
            entity.HasKey(e => e.IpcRevId)
                .HasName("PRIMARY");

            entity.ToTable("ip_changes");

            entity.HasIndex(e => new { e.IpcHex, e.IpcRevTimestamp }, "ipc_hex_time");

            entity.HasIndex(e => e.IpcRevTimestamp, "ipc_rev_timestamp");

            entity.Property(e => e.IpcRevId)
                .ValueGeneratedNever()
                .HasColumnName("ipc_rev_id");

            entity.Property(e => e.IpcHex)
                .IsRequired()
                .HasMaxLength(35)
                .HasColumnName("ipc_hex")
                .HasDefaultValueSql("''");

            entity.Property(e => e.IpcRevTimestamp)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("ipc_rev_timestamp")
                .IsFixedLength();
        });

        modelBuilder.Entity<Ipblock>(entity =>
        {
            entity.HasKey(e => e.IpbId)
                .HasName("PRIMARY");

            entity.ToTable("ipblocks");

            entity.HasIndex(e => new { e.IpbAddress, e.IpbUser, e.IpbAuto }, "ipb_address_unique")
                .IsUnique()
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 255, 0, 0 });

            entity.HasIndex(e => e.IpbExpiry, "ipb_expiry");

            entity.HasIndex(e => e.IpbParentBlockId, "ipb_parent_block_id");

            entity.HasIndex(e => new { e.IpbRangeStart, e.IpbRangeEnd }, "ipb_range")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 8, 8 });

            entity.HasIndex(e => e.IpbTimestamp, "ipb_timestamp");

            entity.HasIndex(e => e.IpbUser, "ipb_user");

            entity.Property(e => e.IpbId).HasColumnName("ipb_id");

            entity.Property(e => e.IpbAddress)
                .IsRequired()
                .HasColumnType("tinyblob")
                .HasColumnName("ipb_address");

            entity.Property(e => e.IpbAllowUsertalk).HasColumnName("ipb_allow_usertalk");

            entity.Property(e => e.IpbAnonOnly).HasColumnName("ipb_anon_only");

            entity.Property(e => e.IpbAuto).HasColumnName("ipb_auto");

            entity.Property(e => e.IpbBlockEmail).HasColumnName("ipb_block_email");

            entity.Property(e => e.IpbByActor).HasColumnName("ipb_by_actor");

            entity.Property(e => e.IpbCreateAccount)
                .IsRequired()
                .HasColumnName("ipb_create_account")
                .HasDefaultValueSql("'1'");

            entity.Property(e => e.IpbDeleted).HasColumnName("ipb_deleted");

            entity.Property(e => e.IpbEnableAutoblock)
                .IsRequired()
                .HasColumnName("ipb_enable_autoblock")
                .HasDefaultValueSql("'1'");

            entity.Property(e => e.IpbExpiry)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("ipb_expiry");

            entity.Property(e => e.IpbParentBlockId).HasColumnName("ipb_parent_block_id");

            entity.Property(e => e.IpbRangeEnd)
                .IsRequired()
                .HasColumnType("tinyblob")
                .HasColumnName("ipb_range_end");

            entity.Property(e => e.IpbRangeStart)
                .IsRequired()
                .HasColumnType("tinyblob")
                .HasColumnName("ipb_range_start");

            entity.Property(e => e.IpbReasonId).HasColumnName("ipb_reason_id");

            entity.Property(e => e.IpbSitewide)
                .IsRequired()
                .HasColumnName("ipb_sitewide")
                .HasDefaultValueSql("'1'");

            entity.Property(e => e.IpbTimestamp)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("ipb_timestamp")
                .IsFixedLength();

            entity.Property(e => e.IpbUser).HasColumnName("ipb_user");
        });

        modelBuilder.Entity<IpblocksRestriction>(entity =>
        {
            entity.HasKey(e => new { e.IrIpbId, e.IrType, e.IrValue })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("ipblocks_restrictions");

            entity.HasIndex(e => new { e.IrType, e.IrValue }, "ir_type_value");

            entity.Property(e => e.IrIpbId).HasColumnName("ir_ipb_id");

            entity.Property(e => e.IrType).HasColumnName("ir_type");

            entity.Property(e => e.IrValue).HasColumnName("ir_value");
        });

        modelBuilder.Entity<Iwlink>(entity =>
        {
            entity.HasKey(e => new { e.IwlFrom, e.IwlPrefix, e.IwlTitle })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("iwlinks");

            entity.HasIndex(e => new { e.IwlPrefix, e.IwlFrom, e.IwlTitle }, "iwl_prefix_from_title");

            entity.Property(e => e.IwlFrom).HasColumnName("iwl_from");

            entity.Property(e => e.IwlPrefix)
                .HasMaxLength(32)
                .HasColumnName("iwl_prefix")
                .HasDefaultValueSql("''");

            entity.Property(e => e.IwlTitle)
                .HasMaxLength(255)
                .HasColumnName("iwl_title")
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.ToTable("job");

            entity.HasIndex(e => new { e.JobCmd, e.JobNamespace, e.JobTitle, e.JobParams }, "job_cmd")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 128 });

            entity.HasIndex(e => new { e.JobCmd, e.JobToken, e.JobRandom }, "job_cmd_token");

            entity.HasIndex(e => new { e.JobCmd, e.JobToken, e.JobId }, "job_cmd_token_id");

            entity.HasIndex(e => e.JobSha1, "job_sha1");

            entity.HasIndex(e => e.JobTimestamp, "job_timestamp");

            entity.Property(e => e.JobId).HasColumnName("job_id");

            entity.Property(e => e.JobAttempts).HasColumnName("job_attempts");

            entity.Property(e => e.JobCmd)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("job_cmd")
                .HasDefaultValueSql("''");

            entity.Property(e => e.JobNamespace).HasColumnName("job_namespace");

            entity.Property(e => e.JobParams)
                .IsRequired()
                .HasColumnType("mediumblob")
                .HasColumnName("job_params");

            entity.Property(e => e.JobRandom).HasColumnName("job_random");

            entity.Property(e => e.JobSha1)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("job_sha1")
                .HasDefaultValueSql("''");

            entity.Property(e => e.JobTimestamp)
                .HasMaxLength(14)
                .HasColumnName("job_timestamp")
                .IsFixedLength();

            entity.Property(e => e.JobTitle)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("job_title");

            entity.Property(e => e.JobToken)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("job_token")
                .HasDefaultValueSql("''");

            entity.Property(e => e.JobTokenTimestamp)
                .HasMaxLength(14)
                .HasColumnName("job_token_timestamp")
                .IsFixedLength();
        });

        modelBuilder.Entity<L10nCache>(entity =>
        {
            entity.HasKey(e => new { e.LcLang, e.LcKey })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("l10n_cache");

            entity.Property(e => e.LcLang)
                .HasMaxLength(35)
                .HasColumnName("lc_lang");

            entity.Property(e => e.LcKey).HasColumnName("lc_key");

            entity.Property(e => e.LcValue)
                .IsRequired()
                .HasColumnType("mediumblob")
                .HasColumnName("lc_value");
        });

        modelBuilder.Entity<Langlink>(entity =>
        {
            entity.HasKey(e => new { e.LlFrom, e.LlLang })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("langlinks");

            entity.HasIndex(e => new { e.LlLang, e.LlTitle }, "ll_lang");

            entity.Property(e => e.LlFrom).HasColumnName("ll_from");

            entity.Property(e => e.LlLang)
                .HasMaxLength(35)
                .HasColumnName("ll_lang")
                .HasDefaultValueSql("''");

            entity.Property(e => e.LlTitle)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("ll_title")
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<Linktarget>(entity =>
        {
            entity.HasKey(e => e.LtId)
                .HasName("PRIMARY");

            entity.ToTable("linktarget");

            entity.HasIndex(e => new { e.LtNamespace, e.LtTitle }, "lt_namespace_title")
                .IsUnique();

            entity.Property(e => e.LtId).HasColumnName("lt_id");

            entity.Property(e => e.LtNamespace).HasColumnName("lt_namespace");

            entity.Property(e => e.LtTitle)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("lt_title");
        });

        modelBuilder.Entity<LogSearch>(entity =>
        {
            entity.HasKey(e => new { e.LsField, e.LsValue, e.LsLogId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("log_search");

            entity.HasIndex(e => e.LsLogId, "ls_log_id");

            entity.Property(e => e.LsField)
                .HasMaxLength(32)
                .HasColumnName("ls_field");

            entity.Property(e => e.LsValue).HasColumnName("ls_value");

            entity.Property(e => e.LsLogId).HasColumnName("ls_log_id");
        });

        modelBuilder.Entity<Logging>(entity =>
        {
            entity.HasKey(e => e.LogId)
                .HasName("PRIMARY");

            entity.ToTable("logging");

            entity.HasIndex(e => new { e.LogActor, e.LogTimestamp }, "log_actor_time");

            entity.HasIndex(e => new { e.LogActor, e.LogType, e.LogTimestamp }, "log_actor_type_time");

            entity.HasIndex(e => new { e.LogPage, e.LogTimestamp }, "log_page_id_time");

            entity.HasIndex(e => new { e.LogNamespace, e.LogTitle, e.LogTimestamp }, "log_page_time");

            entity.HasIndex(e => e.LogTimestamp, "log_times");

            entity.HasIndex(e => new { e.LogType, e.LogAction, e.LogTimestamp }, "log_type_action");

            entity.HasIndex(e => new { e.LogType, e.LogTimestamp }, "log_type_time");

            entity.Property(e => e.LogId).HasColumnName("log_id");

            entity.Property(e => e.LogAction)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("log_action")
                .HasDefaultValueSql("''");

            entity.Property(e => e.LogActor).HasColumnName("log_actor");

            entity.Property(e => e.LogCommentId).HasColumnName("log_comment_id");

            entity.Property(e => e.LogDeleted).HasColumnName("log_deleted");

            entity.Property(e => e.LogNamespace).HasColumnName("log_namespace");

            entity.Property(e => e.LogPage).HasColumnName("log_page");

            entity.Property(e => e.LogParams)
                .IsRequired()
                .HasColumnType("blob")
                .HasColumnName("log_params");

            entity.Property(e => e.LogTimestamp)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("log_timestamp")
                .HasDefaultValueSql("'0x3139373030313031303030303030'")
                .IsFixedLength();

            entity.Property(e => e.LogTitle)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("log_title")
                .HasDefaultValueSql("''");

            entity.Property(e => e.LogType)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("log_type")
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<ModuleDep>(entity =>
        {
            entity.HasKey(e => new { e.MdModule, e.MdSkin })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("module_deps");

            entity.Property(e => e.MdModule)
                .HasMaxLength(255)
                .HasColumnName("md_module");

            entity.Property(e => e.MdSkin)
                .HasMaxLength(32)
                .HasColumnName("md_skin");

            entity.Property(e => e.MdDeps)
                .IsRequired()
                .HasColumnType("mediumblob")
                .HasColumnName("md_deps");
        });

        modelBuilder.Entity<Objectcache>(entity =>
        {
            entity.HasKey(e => e.Keyname)
                .HasName("PRIMARY");

            entity.ToTable("objectcache");

            entity.HasIndex(e => e.Exptime, "exptime");

            entity.Property(e => e.Keyname)
                .HasMaxLength(255)
                .HasColumnName("keyname")
                .HasDefaultValueSql("''");

            entity.Property(e => e.Exptime)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("exptime")
                .IsFixedLength();

            entity.Property(e => e.Flags).HasColumnName("flags");

            entity.Property(e => e.Modtoken)
                .IsRequired()
                .HasMaxLength(17)
                .HasColumnName("modtoken")
                .HasDefaultValueSql("'00000000000000000'");

            entity.Property(e => e.Value)
                .HasColumnType("mediumblob")
                .HasColumnName("value");
        });

        modelBuilder.Entity<Oldimage>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("oldimage");

            entity.HasIndex(e => new { e.OiActor, e.OiTimestamp }, "oi_actor_timestamp");

            entity.HasIndex(e => new { e.OiName, e.OiArchiveName }, "oi_name_archive_name")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 14 });

            entity.HasIndex(e => new { e.OiName, e.OiTimestamp }, "oi_name_timestamp");

            entity.HasIndex(e => e.OiSha1, "oi_sha1")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 10 });

            entity.HasIndex(e => e.OiTimestamp, "oi_timestamp");

            entity.Property(e => e.OiActor).HasColumnName("oi_actor");

            entity.Property(e => e.OiArchiveName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("oi_archive_name")
                .HasDefaultValueSql("''");

            entity.Property(e => e.OiBits).HasColumnName("oi_bits");

            entity.Property(e => e.OiDeleted).HasColumnName("oi_deleted");

            entity.Property(e => e.OiDescriptionId).HasColumnName("oi_description_id");

            entity.Property(e => e.OiHeight).HasColumnName("oi_height");

            entity.Property(e => e.OiMajorMime)
                .IsRequired()
                .HasColumnType("enum('unknown','application','audio','image','text','video','message','model','multipart','chemical')")
                .HasColumnName("oi_major_mime")
                .HasDefaultValueSql("'unknown'");

            entity.Property(e => e.OiMediaType)
                .HasColumnType("enum('UNKNOWN','BITMAP','DRAWING','AUDIO','VIDEO','MULTIMEDIA','OFFICE','TEXT','EXECUTABLE','ARCHIVE','3D')")
                .HasColumnName("oi_media_type");

            entity.Property(e => e.OiMetadata)
                .IsRequired()
                .HasColumnType("mediumblob")
                .HasColumnName("oi_metadata");

            entity.Property(e => e.OiMinorMime)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("oi_minor_mime")
                .HasDefaultValueSql("'0x756E6B6E6F776E'");

            entity.Property(e => e.OiName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("oi_name")
                .HasDefaultValueSql("''");

            entity.Property(e => e.OiSha1)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("oi_sha1")
                .HasDefaultValueSql("''");

            entity.Property(e => e.OiSize).HasColumnName("oi_size");

            entity.Property(e => e.OiTimestamp)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("oi_timestamp")
                .IsFixedLength();

            entity.Property(e => e.OiWidth).HasColumnName("oi_width");
        });

        modelBuilder.Entity<Page>(entity =>
        {
            entity.ToTable("page");

            entity.HasIndex(e => e.PageLen, "page_len");

            entity.HasIndex(e => new { e.PageNamespace, e.PageTitle }, "page_name_title")
                .IsUnique();

            entity.HasIndex(e => e.PageRandom, "page_random");

            entity.HasIndex(e => new { e.PageIsRedirect, e.PageNamespace, e.PageLen }, "page_redirect_namespace_len");

            entity.Property(e => e.PageId).HasColumnName("page_id");

            entity.Property(e => e.PageContentModel)
                .HasMaxLength(32)
                .HasColumnName("page_content_model");

            entity.Property(e => e.PageIsNew).HasColumnName("page_is_new");

            entity.Property(e => e.PageIsRedirect).HasColumnName("page_is_redirect");

            entity.Property(e => e.PageLang)
                .HasMaxLength(35)
                .HasColumnName("page_lang");

            entity.Property(e => e.PageLatest).HasColumnName("page_latest");

            entity.Property(e => e.PageLen).HasColumnName("page_len");

            entity.Property(e => e.PageLinksUpdated)
                .HasMaxLength(14)
                .HasColumnName("page_links_updated");

            entity.Property(e => e.PageNamespace).HasColumnName("page_namespace");

            entity.Property(e => e.PageRandom)
                .HasColumnType("double unsigned")
                .HasColumnName("page_random");

            entity.Property(e => e.PageTitle)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("page_title");

            entity.Property(e => e.PageTouched)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("page_touched")
                .IsFixedLength();
        });

        modelBuilder.Entity<PageProp>(entity =>
        {
            entity.HasKey(e => new { e.PpPage, e.PpPropname })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("page_props");

            entity.HasIndex(e => new { e.PpPropname, e.PpPage }, "pp_propname_page")
                .IsUnique();

            entity.HasIndex(e => new { e.PpPropname, e.PpSortkey, e.PpPage }, "pp_propname_sortkey_page")
                .IsUnique();

            entity.Property(e => e.PpPage).HasColumnName("pp_page");

            entity.Property(e => e.PpPropname)
                .HasMaxLength(60)
                .HasColumnName("pp_propname");

            entity.Property(e => e.PpSortkey).HasColumnName("pp_sortkey");

            entity.Property(e => e.PpValue)
                .IsRequired()
                .HasColumnType("blob")
                .HasColumnName("pp_value");
        });

        modelBuilder.Entity<PageRestriction>(entity =>
        {
            entity.HasKey(e => e.PrId)
                .HasName("PRIMARY");

            entity.ToTable("page_restrictions");

            entity.HasIndex(e => e.PrCascade, "pr_cascade");

            entity.HasIndex(e => e.PrLevel, "pr_level");

            entity.HasIndex(e => new { e.PrPage, e.PrType }, "pr_pagetype")
                .IsUnique();

            entity.HasIndex(e => new { e.PrType, e.PrLevel }, "pr_typelevel");

            entity.Property(e => e.PrId).HasColumnName("pr_id");

            entity.Property(e => e.PrCascade).HasColumnName("pr_cascade");

            entity.Property(e => e.PrExpiry)
                .HasMaxLength(14)
                .HasColumnName("pr_expiry");

            entity.Property(e => e.PrLevel)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("pr_level");

            entity.Property(e => e.PrPage).HasColumnName("pr_page");

            entity.Property(e => e.PrType)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("pr_type");
        });

        modelBuilder.Entity<Pagelink>(entity =>
        {
            entity.HasKey(e => new { e.PlFrom, e.PlNamespace, e.PlTitle })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("pagelinks");

            entity.HasIndex(e => new { e.PlFromNamespace, e.PlNamespace, e.PlTitle, e.PlFrom }, "pl_backlinks_namespace");

            entity.HasIndex(e => new { e.PlNamespace, e.PlTitle, e.PlFrom }, "pl_namespace");

            entity.Property(e => e.PlFrom).HasColumnName("pl_from");

            entity.Property(e => e.PlNamespace).HasColumnName("pl_namespace");

            entity.Property(e => e.PlTitle)
                .HasMaxLength(255)
                .HasColumnName("pl_title")
                .HasDefaultValueSql("''");

            entity.Property(e => e.PlFromNamespace).HasColumnName("pl_from_namespace");
        });

        modelBuilder.Entity<ProtectedTitle>(entity =>
        {
            entity.HasKey(e => new { e.PtNamespace, e.PtTitle })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("protected_titles");

            entity.HasIndex(e => e.PtTimestamp, "pt_timestamp");

            entity.Property(e => e.PtNamespace).HasColumnName("pt_namespace");

            entity.Property(e => e.PtTitle)
                .HasMaxLength(255)
                .HasColumnName("pt_title");

            entity.Property(e => e.PtCreatePerm)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("pt_create_perm");

            entity.Property(e => e.PtExpiry)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("pt_expiry");

            entity.Property(e => e.PtReasonId).HasColumnName("pt_reason_id");

            entity.Property(e => e.PtTimestamp)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("pt_timestamp")
                .IsFixedLength();

            entity.Property(e => e.PtUser).HasColumnName("pt_user");
        });

        modelBuilder.Entity<Querycache>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("querycache");

            entity.HasIndex(e => new { e.QcType, e.QcValue }, "qc_type");

            entity.Property(e => e.QcNamespace).HasColumnName("qc_namespace");

            entity.Property(e => e.QcTitle)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("qc_title")
                .HasDefaultValueSql("''");

            entity.Property(e => e.QcType)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("qc_type");

            entity.Property(e => e.QcValue).HasColumnName("qc_value");
        });

        modelBuilder.Entity<QuerycacheInfo>(entity =>
        {
            entity.HasKey(e => e.QciType)
                .HasName("PRIMARY");

            entity.ToTable("querycache_info");

            entity.Property(e => e.QciType)
                .HasMaxLength(32)
                .HasColumnName("qci_type")
                .HasDefaultValueSql("''");

            entity.Property(e => e.QciTimestamp)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("qci_timestamp")
                .HasDefaultValueSql("'0x3139373030313031303030303030'")
                .IsFixedLength();
        });

        modelBuilder.Entity<Querycachetwo>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("querycachetwo");

            entity.HasIndex(e => new { e.QccType, e.QccNamespace, e.QccTitle }, "qcc_title");

            entity.HasIndex(e => new { e.QccType, e.QccNamespacetwo, e.QccTitletwo }, "qcc_titletwo");

            entity.HasIndex(e => new { e.QccType, e.QccValue }, "qcc_type");

            entity.Property(e => e.QccNamespace).HasColumnName("qcc_namespace");

            entity.Property(e => e.QccNamespacetwo).HasColumnName("qcc_namespacetwo");

            entity.Property(e => e.QccTitle)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("qcc_title")
                .HasDefaultValueSql("''");

            entity.Property(e => e.QccTitletwo)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("qcc_titletwo")
                .HasDefaultValueSql("''");

            entity.Property(e => e.QccType)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("qcc_type");

            entity.Property(e => e.QccValue).HasColumnName("qcc_value");
        });

        modelBuilder.Entity<Recentchange>(entity =>
        {
            entity.HasKey(e => e.RcId)
                .HasName("PRIMARY");

            entity.ToTable("recentchanges");

            entity.HasIndex(e => new { e.RcActor, e.RcTimestamp }, "rc_actor");

            entity.HasIndex(e => e.RcCurId, "rc_cur_id");

            entity.HasIndex(e => e.RcIp, "rc_ip");

            entity.HasIndex(e => new { e.RcNamespace, e.RcType, e.RcPatrolled, e.RcTimestamp }, "rc_name_type_patrolled_timestamp");

            entity.HasIndex(e => new { e.RcNamespace, e.RcTitle, e.RcTimestamp }, "rc_namespace_title_timestamp");

            entity.HasIndex(e => new { e.RcNew, e.RcNamespace, e.RcTimestamp }, "rc_new_name_timestamp");

            entity.HasIndex(e => new { e.RcNamespace, e.RcActor }, "rc_ns_actor");

            entity.HasIndex(e => e.RcThisOldid, "rc_this_oldid");

            entity.HasIndex(e => e.RcTimestamp, "rc_timestamp");

            entity.Property(e => e.RcId).HasColumnName("rc_id");

            entity.Property(e => e.RcActor).HasColumnName("rc_actor");

            entity.Property(e => e.RcBot).HasColumnName("rc_bot");

            entity.Property(e => e.RcCommentId).HasColumnName("rc_comment_id");

            entity.Property(e => e.RcCurId).HasColumnName("rc_cur_id");

            entity.Property(e => e.RcDeleted).HasColumnName("rc_deleted");

            entity.Property(e => e.RcIp)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnName("rc_ip")
                .HasDefaultValueSql("''");

            entity.Property(e => e.RcLastOldid).HasColumnName("rc_last_oldid");

            entity.Property(e => e.RcLogAction)
                .HasMaxLength(255)
                .HasColumnName("rc_log_action");

            entity.Property(e => e.RcLogType)
                .HasMaxLength(255)
                .HasColumnName("rc_log_type");

            entity.Property(e => e.RcLogid).HasColumnName("rc_logid");

            entity.Property(e => e.RcMinor).HasColumnName("rc_minor");

            entity.Property(e => e.RcNamespace).HasColumnName("rc_namespace");

            entity.Property(e => e.RcNew).HasColumnName("rc_new");

            entity.Property(e => e.RcNewLen).HasColumnName("rc_new_len");

            entity.Property(e => e.RcOldLen).HasColumnName("rc_old_len");

            entity.Property(e => e.RcParams)
                .HasColumnType("blob")
                .HasColumnName("rc_params");

            entity.Property(e => e.RcPatrolled).HasColumnName("rc_patrolled");

            entity.Property(e => e.RcSource)
                .IsRequired()
                .HasMaxLength(16)
                .HasColumnName("rc_source")
                .HasDefaultValueSql("''");

            entity.Property(e => e.RcThisOldid).HasColumnName("rc_this_oldid");

            entity.Property(e => e.RcTimestamp)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("rc_timestamp")
                .IsFixedLength();

            entity.Property(e => e.RcTitle)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("rc_title")
                .HasDefaultValueSql("''");

            entity.Property(e => e.RcType).HasColumnName("rc_type");
        });

        modelBuilder.Entity<Redirect>(entity =>
        {
            entity.HasKey(e => e.RdFrom)
                .HasName("PRIMARY");

            entity.ToTable("redirect");

            entity.HasIndex(e => new { e.RdNamespace, e.RdTitle, e.RdFrom }, "rd_ns_title");

            entity.Property(e => e.RdFrom)
                .ValueGeneratedNever()
                .HasColumnName("rd_from");

            entity.Property(e => e.RdFragment)
                .HasMaxLength(255)
                .HasColumnName("rd_fragment");

            entity.Property(e => e.RdInterwiki)
                .HasMaxLength(32)
                .HasColumnName("rd_interwiki");

            entity.Property(e => e.RdNamespace).HasColumnName("rd_namespace");

            entity.Property(e => e.RdTitle)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("rd_title")
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<Revision>(entity =>
        {
            entity.HasKey(e => e.RevId)
                .HasName("PRIMARY");

            entity.ToTable("revision");

            entity.HasIndex(e => new { e.RevActor, e.RevTimestamp, e.RevId }, "rev_actor_timestamp");

            entity.HasIndex(e => new { e.RevPage, e.RevActor, e.RevTimestamp }, "rev_page_actor_timestamp");

            entity.HasIndex(e => new { e.RevPage, e.RevTimestamp }, "rev_page_timestamp");

            entity.HasIndex(e => e.RevTimestamp, "rev_timestamp");

            entity.Property(e => e.RevId).HasColumnName("rev_id");

            entity.Property(e => e.RevActor).HasColumnName("rev_actor");

            entity.Property(e => e.RevCommentId).HasColumnName("rev_comment_id");

            entity.Property(e => e.RevDeleted).HasColumnName("rev_deleted");

            entity.Property(e => e.RevLen).HasColumnName("rev_len");

            entity.Property(e => e.RevMinorEdit).HasColumnName("rev_minor_edit");

            entity.Property(e => e.RevPage).HasColumnName("rev_page");

            entity.Property(e => e.RevParentId).HasColumnName("rev_parent_id");

            entity.Property(e => e.RevSha1)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("rev_sha1")
                .HasDefaultValueSql("''");

            entity.Property(e => e.RevTimestamp)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("rev_timestamp")
                .IsFixedLength();
        });

        modelBuilder.Entity<RevisionCommentTemp>(entity =>
        {
            entity.HasKey(e => new { e.RevcommentRev, e.RevcommentCommentId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("revision_comment_temp");

            entity.HasIndex(e => e.RevcommentRev, "revcomment_rev")
                .IsUnique();

            entity.Property(e => e.RevcommentRev).HasColumnName("revcomment_rev");

            entity.Property(e => e.RevcommentCommentId).HasColumnName("revcomment_comment_id");
        });

        modelBuilder.Entity<Searchindex>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("searchindex");

            entity.HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.SiPage, "si_page")
                .IsUnique();

            entity.HasIndex(e => e.SiText, "si_text")
                .HasAnnotation("MySql:FullTextIndex", true);

            entity.HasIndex(e => e.SiTitle, "si_title")
                .HasAnnotation("MySql:FullTextIndex", true);

            entity.Property(e => e.SiPage).HasColumnName("si_page");

            entity.Property(e => e.SiText)
                .IsRequired()
                .HasColumnType("mediumtext")
                .HasColumnName("si_text");

            entity.Property(e => e.SiTitle)
                .IsRequired()
                .HasColumnName("si_title")
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.ToTable("sites");

            entity.HasIndex(e => e.SiteDomain, "site_domain");

            entity.HasIndex(e => e.SiteForward, "site_forward");

            entity.HasIndex(e => e.SiteGlobalKey, "site_global_key")
                .IsUnique();

            entity.HasIndex(e => e.SiteGroup, "site_group");

            entity.HasIndex(e => e.SiteLanguage, "site_language");

            entity.HasIndex(e => e.SiteProtocol, "site_protocol");

            entity.HasIndex(e => e.SiteSource, "site_source");

            entity.HasIndex(e => e.SiteType, "site_type");

            entity.Property(e => e.SiteId).HasColumnName("site_id");

            entity.Property(e => e.SiteConfig)
                .IsRequired()
                .HasColumnType("blob")
                .HasColumnName("site_config");

            entity.Property(e => e.SiteData)
                .IsRequired()
                .HasColumnType("blob")
                .HasColumnName("site_data");

            entity.Property(e => e.SiteDomain)
                .IsRequired()
                .HasColumnName("site_domain");

            entity.Property(e => e.SiteForward).HasColumnName("site_forward");

            entity.Property(e => e.SiteGlobalKey)
                .IsRequired()
                .HasMaxLength(64)
                .HasColumnName("site_global_key");

            entity.Property(e => e.SiteGroup)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("site_group");

            entity.Property(e => e.SiteLanguage)
                .IsRequired()
                .HasMaxLength(35)
                .HasColumnName("site_language");

            entity.Property(e => e.SiteProtocol)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("site_protocol");

            entity.Property(e => e.SiteSource)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("site_source");

            entity.Property(e => e.SiteType)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("site_type");
        });

        modelBuilder.Entity<SiteIdentifier>(entity =>
        {
            entity.HasKey(e => new { e.SiType, e.SiKey })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("site_identifiers");

            entity.HasIndex(e => e.SiKey, "si_key");

            entity.HasIndex(e => e.SiSite, "si_site");

            entity.Property(e => e.SiType)
                .HasMaxLength(32)
                .HasColumnName("si_type");

            entity.Property(e => e.SiKey)
                .HasMaxLength(32)
                .HasColumnName("si_key");

            entity.Property(e => e.SiSite).HasColumnName("si_site");
        });

        modelBuilder.Entity<SiteStat>(entity =>
        {
            entity.HasKey(e => e.SsRowId)
                .HasName("PRIMARY");

            entity.ToTable("site_stats");

            entity.Property(e => e.SsRowId)
                .ValueGeneratedNever()
                .HasColumnName("ss_row_id");

            entity.Property(e => e.SsActiveUsers).HasColumnName("ss_active_users");

            entity.Property(e => e.SsGoodArticles).HasColumnName("ss_good_articles");

            entity.Property(e => e.SsImages).HasColumnName("ss_images");

            entity.Property(e => e.SsTotalEdits).HasColumnName("ss_total_edits");

            entity.Property(e => e.SsTotalPages).HasColumnName("ss_total_pages");

            entity.Property(e => e.SsUsers).HasColumnName("ss_users");
        });

        modelBuilder.Entity<Slot>(entity =>
        {
            entity.HasKey(e => new { e.SlotRevisionId, e.SlotRoleId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("slots");

            entity.HasIndex(e => new { e.SlotRevisionId, e.SlotOrigin, e.SlotRoleId }, "slot_revision_origin_role");

            entity.Property(e => e.SlotRevisionId).HasColumnName("slot_revision_id");

            entity.Property(e => e.SlotRoleId).HasColumnName("slot_role_id");

            entity.Property(e => e.SlotContentId).HasColumnName("slot_content_id");

            entity.Property(e => e.SlotOrigin).HasColumnName("slot_origin");
        });

        modelBuilder.Entity<SlotRole>(entity =>
        {
            entity.HasKey(e => e.RoleId)
                .HasName("PRIMARY");

            entity.ToTable("slot_roles");

            entity.HasIndex(e => e.RoleName, "role_name")
                .IsUnique();

            entity.Property(e => e.RoleId).HasColumnName("role_id");

            entity.Property(e => e.RoleName)
                .IsRequired()
                .HasMaxLength(64)
                .HasColumnName("role_name");
        });

        modelBuilder.Entity<Templatelink>(entity =>
        {
            entity.HasKey(e => new { e.TlFrom, e.TlTargetId })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("templatelinks");

            entity.HasIndex(e => new { e.TlFromNamespace, e.TlTargetId, e.TlFrom }, "tl_backlinks_namespace_target_id");

            entity.HasIndex(e => new { e.TlTargetId, e.TlFrom }, "tl_target_id");

            entity.Property(e => e.TlFrom).HasColumnName("tl_from");

            entity.Property(e => e.TlTargetId).HasColumnName("tl_target_id");

            entity.Property(e => e.TlFromNamespace).HasColumnName("tl_from_namespace");
        });

        modelBuilder.Entity<Text>(entity =>
        {
            entity.HasKey(e => e.OldId)
                .HasName("PRIMARY");

            entity.ToTable("text");

            entity.Property(e => e.OldId).HasColumnName("old_id");

            entity.Property(e => e.OldFlags)
                .IsRequired()
                .HasColumnType("tinyblob")
                .HasColumnName("old_flags");

            entity.Property(e => e.OldText)
                .IsRequired()
                .HasColumnType("mediumblob")
                .HasColumnName("old_text");
        });

        modelBuilder.Entity<Updatelog>(entity =>
        {
            entity.HasKey(e => e.UlKey)
                .HasName("PRIMARY");

            entity.ToTable("updatelog");

            entity.Property(e => e.UlKey).HasColumnName("ul_key");

            entity.Property(e => e.UlValue)
                .HasColumnType("blob")
                .HasColumnName("ul_value");
        });

        modelBuilder.Entity<Uploadstash>(entity =>
        {
            entity.HasKey(e => e.UsId)
                .HasName("PRIMARY");

            entity.ToTable("uploadstash");

            entity.HasIndex(e => e.UsKey, "us_key")
                .IsUnique();

            entity.HasIndex(e => e.UsTimestamp, "us_timestamp");

            entity.HasIndex(e => e.UsUser, "us_user");

            entity.Property(e => e.UsId).HasColumnName("us_id");

            entity.Property(e => e.UsChunkInx).HasColumnName("us_chunk_inx");

            entity.Property(e => e.UsImageBits).HasColumnName("us_image_bits");

            entity.Property(e => e.UsImageHeight).HasColumnName("us_image_height");

            entity.Property(e => e.UsImageWidth).HasColumnName("us_image_width");

            entity.Property(e => e.UsKey)
                .IsRequired()
                .HasColumnName("us_key");

            entity.Property(e => e.UsMediaType)
                .HasColumnType("enum('UNKNOWN','BITMAP','DRAWING','AUDIO','VIDEO','MULTIMEDIA','OFFICE','TEXT','EXECUTABLE','ARCHIVE','3D')")
                .HasColumnName("us_media_type");

            entity.Property(e => e.UsMime)
                .HasMaxLength(255)
                .HasColumnName("us_mime");

            entity.Property(e => e.UsOrigPath)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("us_orig_path");

            entity.Property(e => e.UsPath)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("us_path");

            entity.Property(e => e.UsProps)
                .HasColumnType("blob")
                .HasColumnName("us_props");

            entity.Property(e => e.UsSha1)
                .IsRequired()
                .HasMaxLength(31)
                .HasColumnName("us_sha1");

            entity.Property(e => e.UsSize).HasColumnName("us_size");

            entity.Property(e => e.UsSourceType)
                .HasMaxLength(50)
                .HasColumnName("us_source_type");

            entity.Property(e => e.UsStatus)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("us_status");

            entity.Property(e => e.UsTimestamp)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("us_timestamp")
                .IsFixedLength();

            entity.Property(e => e.UsUser).HasColumnName("us_user");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("user");

            entity.HasIndex(e => e.UserEmail, "user_email")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 50 });

            entity.HasIndex(e => e.UserEmailToken, "user_email_token");

            entity.HasIndex(e => e.UserName, "user_name")
                .IsUnique();

            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.Property(e => e.UserEditcount).HasColumnName("user_editcount");

            entity.Property(e => e.UserEmail)
                .IsRequired()
                .HasColumnType("tinytext")
                .HasColumnName("user_email");

            entity.Property(e => e.UserEmailAuthenticated)
                .HasMaxLength(14)
                .HasColumnName("user_email_authenticated")
                .IsFixedLength();

            entity.Property(e => e.UserEmailToken)
                .HasMaxLength(32)
                .HasColumnName("user_email_token")
                .IsFixedLength();

            entity.Property(e => e.UserEmailTokenExpires)
                .HasMaxLength(14)
                .HasColumnName("user_email_token_expires")
                .IsFixedLength();

            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("user_name")
                .HasDefaultValueSql("''");

            entity.Property(e => e.UserNewpassTime)
                .HasMaxLength(14)
                .HasColumnName("user_newpass_time")
                .IsFixedLength();

            entity.Property(e => e.UserNewpassword)
                .IsRequired()
                .HasColumnType("tinyblob")
                .HasColumnName("user_newpassword");

            entity.Property(e => e.UserPassword)
                .IsRequired()
                .HasColumnType("tinyblob")
                .HasColumnName("user_password");

            entity.Property(e => e.UserPasswordExpires)
                .HasMaxLength(14)
                .HasColumnName("user_password_expires");

            entity.Property(e => e.UserRealName)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("user_real_name")
                .HasDefaultValueSql("''");

            entity.Property(e => e.UserRegistration)
                .HasMaxLength(14)
                .HasColumnName("user_registration")
                .IsFixedLength();

            entity.Property(e => e.UserToken)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnName("user_token")
                .HasDefaultValueSql("'0x'")
                .IsFixedLength();

            entity.Property(e => e.UserTouched)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("user_touched")
                .IsFixedLength();
        });

        modelBuilder.Entity<UserAutocreateSerial>(entity =>
        {
            entity.HasKey(e => e.UasShard)
                .HasName("PRIMARY");

            entity.ToTable("user_autocreate_serial");

            entity.Property(e => e.UasShard)
                .ValueGeneratedNever()
                .HasColumnName("uas_shard");

            entity.Property(e => e.UasValue).HasColumnName("uas_value");
        });

        modelBuilder.Entity<UserFormerGroup>(entity =>
        {
            entity.HasKey(e => new { e.UfgUser, e.UfgGroup })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("user_former_groups");

            entity.Property(e => e.UfgUser).HasColumnName("ufg_user");

            entity.Property(e => e.UfgGroup)
                .HasMaxLength(255)
                .HasColumnName("ufg_group")
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<UserGroup>(entity =>
        {
            entity.HasKey(e => new { e.UgUser, e.UgGroup })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("user_groups");

            entity.HasIndex(e => e.UgExpiry, "ug_expiry");

            entity.HasIndex(e => e.UgGroup, "ug_group");

            entity.Property(e => e.UgUser).HasColumnName("ug_user");

            entity.Property(e => e.UgGroup)
                .HasMaxLength(255)
                .HasColumnName("ug_group")
                .HasDefaultValueSql("''");

            entity.Property(e => e.UgExpiry)
                .HasMaxLength(14)
                .HasColumnName("ug_expiry");
        });

        modelBuilder.Entity<UserNewtalk>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("user_newtalk");

            entity.HasIndex(e => e.UserId, "un_user_id");

            entity.HasIndex(e => e.UserIp, "un_user_ip");

            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.Property(e => e.UserIp)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnName("user_ip")
                .HasDefaultValueSql("''");

            entity.Property(e => e.UserLastTimestamp)
                .HasMaxLength(14)
                .HasColumnName("user_last_timestamp")
                .IsFixedLength();
        });

        modelBuilder.Entity<UserProperty>(entity =>
        {
            entity.HasKey(e => new { e.UpUser, e.UpProperty })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("user_properties");

            entity.HasIndex(e => e.UpProperty, "up_property");

            entity.Property(e => e.UpUser).HasColumnName("up_user");

            entity.Property(e => e.UpProperty)
                .HasMaxLength(255)
                .HasColumnName("up_property");

            entity.Property(e => e.UpValue)
                .HasColumnType("blob")
                .HasColumnName("up_value");
        });

        modelBuilder.Entity<Watchlist>(entity =>
        {
            entity.HasKey(e => e.WlId)
                .HasName("PRIMARY");

            entity.ToTable("watchlist");

            entity.HasIndex(e => new { e.WlNamespace, e.WlTitle }, "wl_namespace_title");

            entity.HasIndex(e => new { e.WlUser, e.WlNamespace, e.WlTitle }, "wl_user")
                .IsUnique();

            entity.HasIndex(e => new { e.WlUser, e.WlNotificationtimestamp }, "wl_user_notificationtimestamp");

            entity.Property(e => e.WlId).HasColumnName("wl_id");

            entity.Property(e => e.WlNamespace).HasColumnName("wl_namespace");

            entity.Property(e => e.WlNotificationtimestamp)
                .HasMaxLength(14)
                .HasColumnName("wl_notificationtimestamp")
                .IsFixedLength();

            entity.Property(e => e.WlTitle)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("wl_title")
                .HasDefaultValueSql("''");

            entity.Property(e => e.WlUser).HasColumnName("wl_user");
        });

        modelBuilder.Entity<WatchlistExpiry>(entity =>
        {
            entity.HasKey(e => e.WeItem)
                .HasName("PRIMARY");

            entity.ToTable("watchlist_expiry");

            entity.HasIndex(e => e.WeExpiry, "we_expiry");

            entity.Property(e => e.WeItem)
                .ValueGeneratedNever()
                .HasColumnName("we_item");

            entity.Property(e => e.WeExpiry)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnName("we_expiry")
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

