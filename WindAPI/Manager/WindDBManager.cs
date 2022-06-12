//using WindAPI.Models;

//namespace WindAPI.Manager;

//public class WindDBManager
//{
//    private readonly WindContext _windContext;
    
//    public WindDBManager(WindContext context)
//    {
//        _windContext = context;
//    }
    
//    public List<WindData> GetAll()
//    {
//        List<WindData> result = new List<WindData>(_windContext.Wind);
        
//        return result.ToList();
//    }
    
    
//    public WindData Add(WindData newWind)
//    {
//        newWind.Id = 0;
//        _windContext.Wind.Add(newWind);
//        _windContext.SaveChanges();
//        return newWind;
//    }
    
    
//}