using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Shoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        { 
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Product.Any())
            { content.AddRange(
             new Product
             {
                 name = "Nike",
                 shortDesc = "Сьогодні Nike є одним із самих пізнаваних брендів у світі. Заснована п`ятдесят років тому, ця компанія встигнула обігнати й залишити далеко за багато ...",
                 longDesc = "На сьогоднішній день Nike продовжує залишатися на гребені хвилі. Вона спонсорує знаменитих спортсменів, улаштовує спортивні заходи й розробляє революційне взуття. Її реклама надихає, а логотип є самим пізнаваним серед усіх спортивних логотипів. Як не крути, але компанія Nike власним прикладом підтвердила свій слоган — Just Do It (Просто зроби це).",
                 ing = "~/img/завантаження (1).jpg",
                 price = 1500,
                 isFavorite = true,
                 available = true,
                 Category = Categories["Кросівки"]
             },
                  new Product
                  {
                      name = "Puma",
                      shortDesc = "-одна з найстаріших компаній у світі спорту, що представляє взуття",
                      longDesc = "Усі новинки націлені на підвищення комфорту під час руху. Взуття PUMA ,особливо моделі для бігу,має спеціальну систему амортизації.",
                      ing = "",
                      price = 2250,
                      isFavorite = true,
                      available = true,
                      Category = Categories["Кросівки"]
                  },
                   new Product
                   {
                       name = "Adidas",
                       shortDesc = "компанія відповідальна за дистрибуцію продукції компаній: Adidas, Reebok, RBK & CCM Hockey, а також Taylor-Made Golf. Adidas є найбільшим виробником спортивних товарів у Європі і другим у світі, після американської компанії Nike.",
                       longDesc = "В Україні, на відміну від решти світу в цілому, торгова марка Adidas набагато відоміша за своїх конкурентів, можливо, це пов'язано з тим, що Adidas імпортувався в СРСР з 1979 року. Також це викликано поширеністю китайських підробок цієї марки.У взутті Adidas перемагали Мухамед Алі, Джо Фрейзер, Штеффі Граф і Стефан Едберг, Боб Бімон і Гунде Сван, Лев Яшин і Валерій Борзов, Мішель Платіні і Ейсебіо, Зінедін Зідан і Девід Бекхем, Марат Сафін, Ліонель Мессі і багато інших спортсменів. У багатьох з цих людей підписаний контракт із компанією.",
                       ing = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxMTEhUTExMWFRUXGB0XFxcYFxgZGBgXGBoXFxoYFxcYHSggGx0lGx0XITEhJSkrLi4uGh8zODMtNygtLisBCgoKDg0OFQ8PFSsZFRktKystKy0rKysrLS0rKystNystKy0rNzcrLS0rLSstKy0tNysrKysrKzcrLTc3Ky0rLf/AABEIAQMAwgMBIgACEQEDEQH/xAAbAAABBQEBAAAAAAAAAAAAAAACAAEDBAUGB//EAEMQAAEDAgMECAMGBAQFBQAAAAEAAhEDIQQxQRJRYXEFBiKBkaGx8BPB0QcUMkJS4SNicvEVM5LCQ4KistI0RFRjk//EABcBAQEBAQAAAAAAAAAAAAAAAAABAgP/xAAaEQEBAQEBAQEAAAAAAAAAAAAAARESAjEh/9oADAMBAAIRAxEAPwDjGdIuj8R8SjGPd+orLY5H8QojQbjn70xxjt58VQD5zTuqD6Ii597dvRfeeN/7Ki1yJhQXG4g703xTvVQGE5f/AGQWhXMZ805r6aKttWTPcgs/F5pnVeKrEpy5BMKspbRKgEpwSglL7ZoXvUZJ80Lioo3VEAPchL0BJUBufyTbSBzkMooygcSmBTByByglIlNKBpTppSQSBFKiDkQWkGDdFqgT7SCSU4cEA8E7eSAgjPJRbKKUB7SW0gDjqnQETuSlCAl3oCDuSbaSlMoEXHeltE2QJIHUZKJyDuUCJTEpygCBFMXJ3JgimPNMTZJxQlA3xOCSQpjekglBREqOUW1wWkG3vRFRtRkoCBS2kIKTVBK12aUoIRAoCLoySLgmCaUDgpShhORJKKdIFMU20gcuKaUnFCCoESm3pQgQPKH0TkoQgUlMlKZApQkpyUBCBJJbfBJAbSjDlGEUKokaE4QhJAZJSlMPJO1FPtJ+5MCnJugQKdbvU3q8cbX+F8QU2NaXvdEkNBAs3UkkBeg4v7MsCaU069drwDBOw/aMW7MN8ARnmg8hSCtdIYF1JxBu2YDwCA6NLiQ7e03CqOKmmClNCYhJA70EJ5TIGJTEpyUyAYTdycoUDoQmcUxKBihLkSEoBjikldJBMESFrUtlUG0op1QImogmlPKEjikii1S2kM6JxJIABJNgAJJOgAFyeCDvfsppnaxT9G0mtJ4veCB4MPgu3oYrtbBNj6qv0T0QMBgmUDHxn/xK53PIsydzRbnJ1WRjsRuN1FjL+0TAOw9QugGniWy4OmGVmCBVG47LhP8Azb1wtRzDGy7aOzLhBBY4Wc06ETkQbgjIyB6p9sjop4dh/FF+cMBWZ9lXVnD1KVWtXZtkvdSAOWzAnxkLPxr688BTWW11x6vuwWINPOm6XUn72bj/ADNsD3G0wsOZWmDkpighNKAyUJQucm2kBIZQOeh20BOcmnigLkBegklAShLkG0gJJBtpILYKQKjD0g5UTFJpUW0n2kGp0N0ZVxVZtCgwve7IaADNzjkGjefouxH2SdI7UH4DW6vNU7PcA3a8lP8AZvg61OiarK3wHVH5EEFzGQBfPZkviLL02h0m51GmSSSWh0kz+ITnrmrfwcFhvsnotEVsY4u/+umA0c9oku8lZ6sdQWYTEnEVK7K7aQBogNLT8Qz2qjTIAbmIJkkG0Lp6hc4wJJ4KtTou7Yc5rLAAuPG+UlY6axmdNY0kknVZnV7CHEYukyOztbTv6W9o+MR3rardD03fjxTBwY1zj5wtLog0cMD93Y4vcINWpAtua3Qa+uSaON+1+pUq4pjGU3uDW3LWkiScrDOIPetzqFhnUcGxrhDnOc8j+owPIArVxeKDrQDrJGpUNKoVNaxH1r6HbjaBpSA8HapuOTX8eBEg8DwXh+Pwz6VR9Ko3Zexxa4bnAwefNe903SQvN/tR6DqOxAxLLsqiHSfw1GiB3OaAebXb0lSxwZehLldb0LU1LR4qZnV95zd5futM4yi9C563WdW95cfD6KZnVtmoJ7ymnLmXPQGoutHQDP0j1U1Loho0juTV5caJOQPgl8F5/KV23+GDciHRo3KacuKGCqHTzRt6MqFdp9xTswPBNOXF/wCFu3jwSXZfc+HkkmnLg9tOHrrafQLf0jwVql0U0aR3Ks44sNccmu8Ctfqx0I/E4qjQLXBr3jbOUMEufHHZB710bejxuXZfZ/0MW/GxIaX7DdgNBgkuu465AC2s8E1cdc+qxtNwYA0U2bLaYADWsEhsN3dkjuUVCkSGsAyAHCw9Fj0uiKuJeH03VGtcO3cBh+GazWtJi/afMTeAdF0tXCljXS9oJaRmddMkqxlYrGySymYYM3DNx38tw+qysLXLg7bpOYQ4tG24HaAycIJgFW/gxYGeShqG8H37+qw0dpDRYXQmuTldFbd439UQKAGscdw98FJTdZRuqQovi5nSfFFaFJ0kAZnLlqVfqdH0Xs2K38QSDstJDbXEuzPdC5rA40/FfJzAA5CZC3KVVIMjpDrBWbVfg8FhqeHa2z6r2DZu0kFrRO0DYbR2s7gQocH1TqVRLX0ydZaae07+UAFuUZGN1lt1qPbbWDdp7Bdv62zMRltA3aTkZFtolVsd1mpseGUgKpIJe1piowlm3ScZyY4gtnQuatI5rE9GupuLXtLXDMHP6EIPuvevSBgPvFq47DfwuFnGRofUZW1XJ9LdH/BquZMjMHeD8+CmGsJ2G4IXYS2S1HMQBgO5XF1nDD8ExoLQdSCjLJ4pgpmgNyY0lccyULmpiM80m+/7JloeCSmCnTw6kFDyVynS33UgbuW8c1RuFuIEkmAN50EL0Xqpg3YVhpVQJc8ulpkCzRsu3Zclx+Cq/Dex5bOw4OjfBBW0zpIVKrWnaaXOgepuNwUqunr4lrOyG7NyYaAASZJ7ydVg9JdKhx/y3CF0DsQ0MkbLjpJFuF1yeOrOc+DsunMti2ee+9u9S1ZFGvXa0uqnsw2+cQJMxv4rxPprpd9fEPrO22EmGiXNLWDJtuFzxJXtrhLo/Tc89Pr4JVWMcO2xrt4IB55qRa8RpdZcVT/y8TV5Odtj/rBWzg+v+MaBtik/gQWu8WmB4L0PF9WsFU/Fh6d9WjZ82wsLFdQ8ET2BUaeDyf8AvBVRN1b6wvxczRNNozdtS2dwsCStxx8sh71UeAwjabGsYIa0QN54lZ/TeN/4TDBP4iNBuHFZbg6R23yCQAbkR6my6TA4xkCQ4A5OEOEb7Ll8DGyGjlvnmNVr4OqGw2zYFgIAgWsBoLItdRh2bV2EPHDTnOSnwvQdOXF4DgTtACRsnNw2gci7tRvJ3rCwvSWzYMIAOW87zouiwVX4omo/YGjGmJ5uzVZrRr4xrQGNicmtaJPCwT0sOynTeXgEOlz5uL5iDp81T+FR2w3sSBbZPaGkzMhQ45rqrXUydocrmMjbI/NVMc7/AIS+oXOpMll3C4kD9PE8FmkLs+i6fwqcjNx8m29Z8AsvF9FuxFR76TW2uRlJ3jSTc6IrnXBDCm520hC4Kiu4IQPd1M43UbnTlfzKAdn+U+CdD8Xl4FJBO0Ig0Dena3kjatObT6udGitV7d2NbtXsCZgA6xr3IaOFqmsQ2kX1GyS2QAJMXcbC37StDod33YgVSB8YA8WATsl3OctLLdxVYUmveB2iAJH5tB3ifBYv7VYvSHR7Gtg7IMlxbMmXEndGvqsLH4plCk+o6waCTGZjQcTkOJV2vWNQ9oTxOfkoHDadwb6+/ko08GxvTNZ9Z9Y1Htc9xcQ1zmxmA2xyAsrdLrPiWi2Jq8i4O0/mBXtdbDUnjt0mO5tafUblQrdXsC8drC076BoBvyVZeV0+u+OA/wA0O/qYyfIBejdWadU0W1K7i6pUAcdzW6AAWCI9UcAHWwzJ4lxHgXQtV0NbYAACwFgAMgEaitjq+w22ZXLvZeSc/dytzE4jaBLHSNWnQ8WnJYtfPKOWXgfqstpxjm0mF5Ia1oknkvPcd0niMZimmntB87NINJBaOYyOpPyC3+suFrVWBlIAiZcJAJjIQdNc9ArHUbo74AdUqNiq6wB/K39z8lqM13XRVCpTpMbUqfEqAdp0AAnhAt84VvCV2vlzHhwJiQQYixAI3GZXmnXPrib4eg4jSo8G/FrT6nuRfZl0LiC74/xHUqH6dKpy/CbR/NnuRNex9GVgHASAON/BdFgqbRcE95A8guBrVWs2XOeG6NcTsmXRAk6kxbkrDauzBcXPEi0nfqort8SZ/N4X9FUwrzTbUzBLgASIsBM+ZzVWn1jAEObPBun0WoC2sxhAOyZ2suXmqjkcZgn1BUrtAIm4yJ4ga2gnmsgewut6cxopsJawmBDWNjwHqSuVfMB2y5oO9pHcd6aqEEQo3e7XUxegc6yqWoCOfvvSR7PFJEW/EqXD0HOOy1pJ3C58BwUIFs1r9Wnn44g3h2etsve5arLb6wdGGuBskNc3syf0E/7TfxVfEu+BSbQaTV2R+KoZd8v2Vyg403xtDYNwHHtMOomIc03vMjcsHpHCnaJc6Zvb9litRQxmPbTpuqP7IaC52sASTlnYLxOt1mxbqj6ja9Rm24u2Q87LdwAJiwgTwXtNbBtedizmxLmuuDukc/RVq3V/Cn8eFpf6APRZ1ceSUet2N/8Akv7ww+rVJU6540D/ANSf/wA6X/ivTndUMA7/ANu0ci4ehUFTqXgBlhwf+Z/1V1MYn2dYjEYl1SvXqF7W9hkwBtG7iA0AWbAniV2WNyACfAYCnRbsUmNY0XhogSdTxhQ4yoCSN1lqftX457pLASdpsg6Ftj4ysTE4uvTN4qDiId4t+i6mtWBtn36rGx+z+K8ZG3zWsNZtPp2kTDw5h4iR4jLvWpQc17Za4OadxkeSw8ZhWkaXyOveufqU3U3bTHFjt7TGWh38is2GukodTqRrtcSfgi7mG5kRAnVp118V2XS3T9DCUg5xAAEMY3N24NHsBcX1a61y4UsTAJs2pkCdzxkOeXJXOtvU91d3xaJ7dg5jjYj9TTpGZHhfOI5Tpnp2vjqokEyYp0myQJ3D8zuPoLL1Hqd0ViKVENxFUudmGGHbA/SXZu8YGQQ9TurFDCt2h26xEOqEXHBo/KPM6rpRScLi6lqxFTrAGIghauE6fdAYWBnvh6rPp4cOJmx0Q02kODTmDbUb89PeWSmtN6iwONxK2MNhAWkEAg5giR3hZ2AIi612VRCRK5zpjqq0guoWIvsEyDrAm48+5cdVaWkhwgixBsR3L0/E4wAXvx9+q4brL2n7ccDlloT3/Ja1nGP8U8PfcnQfBm8G/FJXVxoNghXOisG6o/ZaYjtF1+zuNjyWeDunh3/PJd30H0f8KkAfxu7TucZcAMp5rVYZlf4gaGPPxCPzkAE8wLTyWSSbuy0gldfXoAj58Brw4DvXMdL0NkgwdkntRoOIz3AkaLnW4gw1M7O1qbqRtYEQUP3m0EQR3d8KviHfmHePfvzWWhVeEIKX6jp6qNo2su9EHTl+EZcTvU0LE4gU2Oe7ICe/d42XHnpIFxk56+HzWd176xh7/u9My1h/iEZF/wCnu9eS5qnjDxXTyza66pjgN5BiPHgq1fEB1pmeNlh0sWTkcualdjNJjeFvUWKzuI+fos+sy5v/AGVh1bwjco36b1NRi43Dyu46i9YNprcPWd2ham85mPyE79x1HnzVab28VWdTvItvA9eBUI9nBGtj+r6q23EOAvlvGS866C65OZFPEgubpVFyP6wM+Y8NV2eCxTHt26NQEH9JkeC51uNOliBe+qb72NsAfq/2uVM1NC3vbbyQjY2g6XTGREDxhTWm9SxsKb/ECRmsN1cDf77kIxQ+imjUr4wkQsvpF8U3T7uEJxgyBvuF/fesXrB0sKYa0uhzzIE5NGZPp4qyoIVE6yx0izePB31SW9R3fVuhtVhIs0bUbzkB8+5doXaTzPyXA9D4r4byYgERw0Wu/pglvP5rXq4xI2cZihsnj6LDxuKmVUr40lVH1JXO+m5EFWvB2f8ASTkR+nmPMX0KejWLsu/hzTVQCIdceyCCNdbIGvtsizRrqVnWsTFw/C38Op3ncFy3XfrR93Z8Gkf4zhmP+G3f/VuHfzHrZ1ubhwaVKHVo7qfF3Hc3x4+Zuc57i5xLnOMkm5JOpW/Plm0qY95q8xhhNQpW3e8lbZT4HfktsFTbbXugWU33cyNOMnMb/JTU6eUtOnD3uU9OlMZC+WfHLNGsRNoWkZjSJHmPNO1hztnfK3grIYDeTnEBuQ4e9ynbhwRBsZ48QQfe5DGb8C++PeiCrQGULVZQ1DeE7841+SN7dIHp71RMYhw418dDxT0g5jtqm5zHb2kiecZjgVrnDyYO6ZtHkU33TZHyiY8bc1BJhus+JpjtbNUcey7xaI/6Vfpdd6ZtUo1G8W7Lh5EHyWYcNwHv35KKph4Md0wPedu5TF10TOuGCOby3+qm8f7VFX614ET/ABZndTe7/auafghulQ/cGk5einEOmxjOvbQNnD0iTkHvENHENFzysucbWqVKhqVXlzjmT6AaDgFZGCg2lWaPR7gRIMTec1ckNXG1xH5vE/RJSikBa/gEkxXYGrDhfUk8h38VJTxLTk7uVKtUnOLa2XM9L1nsJfTJDuRLTfIjXX9lr151mV2/xxqoqmKAMRfcPouEp9cgP82i4OGrII5jaII5XTV+vIA/h0HE/wA5DRzhsyuXNa13Ln2LnGBG+wHE5Lh+snXbOlhDwNWLcqY/3eG9c70n0riMTao/sZ7DbM8Mz3kqvQwnuCtTwl9KtOiSdSTc8TvJK0cLhbhWWYQDPl3q/QYDPdv8hYLbMV6dDhE3y4E5qyxozIzGZHp4FSU6U2uddBbn4qZ1PKYnnlpm6ZUbB8OYEHhaMuAzU1NnHjPP+Ud9kTGZkXI58crqYH8J8txv770Cp0wbjOOMQe9SMpCxNyORvnnqpKIiwaN3GCJ+qHZLgbEcSctOG7LggF1ObQYndv56pxRvJEfXWMualbSAFjnf8UDlayKk0gkRx78o5/sqlMaJm3y970hh5zDeczkDuUrm2vpM2Jkcd2osk8nQW1nuOvuyIhp0BNhbMm/gPeiJ+HaeUe9eCPS1+W/f6KVsEd2vfp4oKpwwP0Go8pTfAj8LeY+cZf3VttQWyn19+iJjRoIHMfPwtzQVDhTpYjL3qjNEETAiN8AfsrTmBwtmNe/34otqAd3hx70GcQdD/wBLElbhu8/6nfRMi6ukmDu5gGPosnpCDLczbwjXjqthri4nONO630yVTEzcgjjpe8mVtlyWN6Km4Ed2nBZpwMfRdrWwY3kkztTGlh5qk/ouSZBgkbvLvWaObZQg6e+KsfBBztrb+25ax6OaLA2yj6bslMcKzXdAk5qKyqeFteZneBruz324q/TwsAxIi3aFjrProrNFgNw2Z5n9kFLDG0Nzzy7+SixXoA663AA9EdBjS0m5kHPObGLa5aq0/DkwSLWNv6SO68I6NHZkQCQJAMza1u+EVXwzTe2yDaeeVzxMXVkN2Wgdm18pgHjkjDQDfdytY3Oam2RM3sc9N+Z9UELacjauAJvEDhkETaEiRJ9NJjdkpviHZg7IPrbOUzYI96aCfDmgZgNobNucx3j2UdKkDnYTpEyN/mE9RkcO8aW3qOo2QQCOOQz95TuVCpgDMezwjQhE91wQDuMWufS6QAHaAEZxqMjYxvCkDrnhlpw0ujISIOzAE+7HUo2TawPEC3n3H3cTrkP5sv3/ALpCfHxnVBJlfTJ2UAznHA+GSHavMaXGy7zv8kdIyD2u4m3Gd2ihqE27XKdCO9UTEk68xMW0NgonUwLTfhvziYhLYtJJ3i+X9skrDMCYzA177XQBtDVhPHf5pIy4+2/ukqLbeQy00PeonDZMEiCct/MDh6BStGe1a2gGUi10hAH5QIz3yNr13qorvaDqcsgSMp0lB8ET3yeByzOv7qao6TAF+JOts/eaCmztQSBFzlOZiBuRVV9Jotrlz1+eianRkTsiwsLiJv8AXxU76AyzjhmBr5KWm0xNzbS95GglQU207RO0c5iOEybeSk2pzgxfM5gjhA0KKpbQd+hnjl73JYYxN94m+8Tkpiq9STcNEG+W8DeJKlLSImAMss9NyVSMjfMAQJF9wziylpNt+3lbvTFQBouJJ5HnvHJHcg5TEgHgcgpzTvIjfcnj77kDIEgHtC4jXu5hQMylsm2UaeXDVO8Nz1MZb88zxnxRBpAGhAzMaAjylNVcNHE8AMp4j0VwCYNwZJ3DKEdOMgDGRMcp47kDGgG34v2g8zl+yanM59wnu4f2TEGAG2k3J48M/DxSY2ZInU7s+73dPTETaLwJO6B4R8k9TS025jzucvVMQOwJl2s+NtQfd8oRPFwSJaBH7yfeaJxtsuJjOAB4nJC4jdrfXPTID1zCoN7Rv8TPAz3Xjmo6jDIg9nwuBqYySok2GWtxMc9x4hFWrmLCxytpna5Ji6CB7oMG4Npzj/SdPqnbtAOkiNeOdh8kmtvvkTOk8k5B523X3ZhUT9nh/pckoBTJvsnwHzukoJWxIHG5sJ8TvCd77SZJJynmeSFxEiXSRzOWtjc30TuMcTfQRoJ11K0iQvuQCBAyi5+Wh8kIqZ2OgFgd4vGXclVE3tE2m+uY8lHsmBO0JvmBlpw1soqSo24AI4gwTAkD1UfeTIsBrcHdGWn0TwIBi+tjxt6qP4WQJyGpvpxGQ4aIDqiDkDzN89I4T5odAAALnkZ9PNG51otlvmYFsjzzTCm3zHDOOOWiAfhbREkGRuPj2c0bKBzDTNpJBBseI99yVFuvgbzlJgxbI+83NSxLRcdwg/uoqKkwGN+RGv0t9UYBB7LRpxPgMzn4KRwBeCTs33DUTme9NWi0uOW65iT7hBFVLg69x3C8245Sl8TaEkX1sbCCbypDUMZRxiPW+7NJjycySCN1s+Oulv7ENRMReTlxsPfmk6Iv+I6wN0xAuifUyJJjcJjce/8AZGxzfy3nKbCO7iOKAG5QM9QbZ6/uhyuSY0jhnxtlEI9gCSXTrABmN3db0Sc8CDAnMT55Ze96oGs4bQgRNpN8t1iJ0Q1Hn8Oc8NOWUIqlUnVuUxnleb2zTMEtuHdm/dwaN1tdUATABBIi9uZEQPrqnLxrPfzsbJNubNMTESRfgNPHRJzBM2HIznlYa8+Kgd9ogG17iY7jqnNWTqJvcxByiNL6JmmZnLIX3cPeiASBYG2eltOOkTyVQbsIN58AnS+I3Vw7wJ7+KSKINBAnWZ7k9I9lnG/CYbokkqixsAE9/lEKuHTHP9kklFWMU0Blt48y0H1KzqdIBwt+YDx2ZTJILGJaNnw9CfVKpTAyA08zdJJA2GP8La1Akc9knLJNQcdhztZ+ROXNOkikfxOHAergjJv45W9EkkQfwhB5kZncSoMOdoFxJJmJ706SCxUaBEDUBR1rMnh9EkkFNlU7QE2O1/3FWGMEC2reeR17gkkgcMAAIGvqDMKvhKh2jyCSSCaq6JjQn/d9Ai2Rsz7yJSSQQAwHEbv/AC+gUtRvYYcyQJm+YZOfMpJIH+GPZKSSSg//2Q==",
                       price = 1700,
                       isFavorite = true,
                       available = true,
                       Category = Categories["Кросівки"]
                   },
                    new Product
                    {
                        name = "Skechers",
                        shortDesc = "",
                        longDesc = "",
                        ing = "",
                        price = 3500,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Кросівки"]
                    },
                     new Product
                     {
                         name = "ECCO",
                         shortDesc = "",
                         longDesc = "",
                         ing = "",
                         price = 3500,
                         isFavorite = true,
                         available = true,
                         Category = Categories["Кросівки"]
                     },
                      new Product
                      {
                          name = "braska",
                          shortDesc = " braska— український бренд модного взуття, а також одягу та аксесуарів, що був створений компанією INTERTOP Ukraine у 2004 році. ",
                          longDesc = "Колекції бренду – сміливий мікс актуальних тенденцій із класичним та спортивним стилем. Кожна пара взуття – це поєднання трендового дизайну і відмінної якості.",
                          ing = "https://intertop.ua/load/BS3368/412x550/1.JPG",
                          price = 3500,
                          isFavorite = true,
                          available = true,
                          Category = Categories["Кросівки"]
                      },
                       new Product
                       {
                           name = "GEOX",
                           shortDesc = "GEOX — італійський бренд, який прославився своїм взуттям, що дихає. Засновник компанії Маріо Моретті Полегато створив свою першу пару взуття для щоденної ходьби, зробивши у гумовій підошві кілька отворів для поліпшення вентиляції.",
                           longDesc = "В основі бренду лежить ідея поєднати практичність гумової підошви з властивостями спеціальної мембрани, що не пропускає вологу, але дозволяє ногам дихати. Згодом схожа технологія була реалізована в колекціях одягу: куртки Geox забезпечують відмінну терморегуляцію та захист від вологи та вітру.",
                           ing = "https://intertop.ua/load/XW4022/412x550/2.jpg",
                           price = 4230,
                           isFavorite = true,
                           available = true,
                           Category = Categories["Кросівки"]
                       },
                        new Product
                        {
                            name = "Marc O'Polo",
                            shortDesc = " Marc O'Polo— бренд одягу та взуття, що представляє сучасні базові речі преміум-класу для жінок та чоловіків. Бренд був заснований у 1967 році у Стокгольмі. Перша колекція складалася всього з трьох моделей бавовняних сорочок, вироблених вручну, а вже за декілька років Marc O'Polo запустив повну чоловічу і жіночу лінійки.",
                            longDesc = "Натуральні матеріали, висока якість і лаконічний дизайн дозволяють легко комбінувати речі бренду у модних образах та проявляти свою індивідуальність. Marc O'Polo залишається вірним ідеї: «Слідуй своїй природі», що втілює скандинавське коріння та мінімалістичну естетику бренду.",
                            ing = "https://intertop.ua/load/PY1098/412x550/MAIN.jpg",
                            price = 2100,
                            isFavorite = true,
                            available = true,
                            Category = Categories["Кросівки"]
                        },
                         new Product
                         {
                             name = "CAT",
                             shortDesc = "  ",
                             longDesc = "",
                             ing = "",
                             price = 3500,
                             isFavorite = true,
                             available = true,
                             Category = Categories["Кросівки"]
                         },
                          new Product
                          {
                              name = "TIMBERLAND",
                              shortDesc = "– легендарний американський outdoor-бренд взуття, одягу та аксесуарів. Timberland був заснований у 1952 році одеським емігрантом Натаном Шварцом. Саме він увів у використання інноваційну технологію лиття під тиском, що забезпечила максимальну водонепроникність взуття.",
                              longDesc = "Візитівкою бренду протягом багатьох років залишаються жовті водонепроникні черевики — The Original Yellow Boots. Легендарні «жовті» черевики Timberland навіть представлені у Британському музеї дизайну.",
                              ing = "https://intertop.ua/load/TG2262/412x550/MAIN.jpg",
                              price = 2899,
                              isFavorite = true,
                              available = true,
                              Category = Categories["Кросівки"]
                          });
                         
            };
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName= "Черевики", desc= "Сезонне взуття"},
                    new Category { categoryName= "Кросівки", desc= "Розпродаж"},
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
               
                return category;
            }
          
        }
    }
}
