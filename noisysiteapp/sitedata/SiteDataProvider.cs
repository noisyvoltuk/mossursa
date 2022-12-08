using LiteDB;

namespace noisysiteapp.sitedata;
public class SiteDataProvider :ISiteDataProvider
{

    private LiteDatabase _database;
    public SiteDataProvider(){
        _database = new LiteDatabase("SiteData");
    }

    public List<Embed> GetEmbeds(){

        return (List<Embed>)_database.GetCollection<Embed>("Embeds").FindAll();

    }

    public Embed FindEmbed(string id)
    {
        return _database.GetCollection<Embed>("embeds")
            .Find(x => x.Id.Equals(id)).FirstOrDefault();
    }

    public bool InsertEmbed(Embed embed)
    {
        return _database.GetCollection<Embed>("Embeds").Insert(embed);
    }
}