using WindAPI.Models;

namespace WindAPI.Manager;

public class WindManager

{
    private static int nextId = 1; 
    private static List<WindData> data = new List<WindData>()
    {
        new WindData() {Id = nextId++, Vindhastighed = 1, Vindretning = "N"},
        new WindData() {Id = nextId++, Vindhastighed = 2, Vindretning = "N"},
        new WindData() {Id = nextId++, Vindhastighed = 3, Vindretning = "N"},
        new WindData() {Id = nextId++, Vindhastighed = 4, Vindretning = "N"},
        new WindData() {Id = nextId++, Vindhastighed = 5, Vindretning = "D"}
    };
    
    public List<WindData> GetAll(int? vindhastighedFilter, string? vindretningFilter)
    {
        List<WindData> result = new List<WindData>(data);
        
        if (!string.IsNullOrWhiteSpace(vindretningFilter))
        {
            result = result.FindAll(WindFilter =>
                WindFilter.Vindretning.Contains(vindretningFilter, StringComparison.OrdinalIgnoreCase));
        }
        
        if (vindhastighedFilter != null)
        {
            result = result.FindAll(WindFilter => WindFilter.Vindhastighed == vindhastighedFilter);
        }

        return result;
    }

    

    public WindData Add(WindData newWind)
    {
        newWind.Id = nextId++;
        data.Add(newWind);
        return newWind;
    }
}

