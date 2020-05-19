const url = 'https://api.apify.com/v2/key-value-stores/tVaYRsPHLjNdNBu7S/records/LATEST?disableRedirect=true'

/*using https://apify.com/covid-19 to fetch data*/

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
    data.forEach(element =>  {
        div.append(AddToDom(element))
    });
}

function AddToDom(data)
{   
    
    let content = document.createElement('li');
    content.id = "textElement";
    content.innerText = `Country: ${data.country}\nInfected: ${data.infected}\nTested: ${data.tested}\nDeceased: ${data.deceased}\nRecovered: ${data.recovered}\nUpdated: ${data.lastUpdatedApify}\n\n `;
    return content;
}