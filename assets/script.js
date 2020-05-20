const url = 'https://api.coronatracker.com/v2/analytics/country'
/*using https://api.coronatracker.com/ to fetch data*/

window.addEventListener('load', () => {
    fetchUsData();
})


async function fetchUsData()
{
    const option = 
    {
        method: 'GET'
    }
    let div = document.querySelector(".list");
    const response = await fetch(url,option);
    const data = await response.json();
    console.log(data);
    data.forEach(element =>  {
        div.append(AddToDom(element))
    });
}

function AddToDom(data)
{   
    
    let content = document.createElement('li');
    content.id = "textElement";
    content.innerText = `Country: ${data.countryName}\nInfected: ${data.confirmed}\nDeceased: ${data.deaths}\nRecovered: ${data.recovered}`
    return content;
}