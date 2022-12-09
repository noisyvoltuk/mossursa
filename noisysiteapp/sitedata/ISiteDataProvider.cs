using LiteDB;

namespace noisysiteapp.sitedata;
public interface ISiteDataProvider{

  

    public Task<List<Embed>> GetEmbeds();

    public Task<string> InsertEmbed(Embed embed);

    public Embed FindEmbed(string id);
}
   