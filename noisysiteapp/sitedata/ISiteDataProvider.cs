using LiteDB;

namespace noisysiteapp.sitedata;
public interface ISiteDataProvider{

  

    public List<Embed> GetEmbeds();

    public bool InsertEmbed(Embed embed);

    public Embed FindEmbed(string id);
}
   