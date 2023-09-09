async function callAPI(start,endpoint){
    fetch(endpoint).then(blob => blob.json().then(data => {
                            postmanResponse.push(...data.data)
                            if(data.count > 0){
                                start += data.count;
                                const nextEndpoint = `https://rest30.bullhornstaffing.com/rest-services/59klg/query/Sendout?sort=id&count=500&start=${start}&where=(dateAdded>=946677600000)AND(dateAdded<=1672524000000)&fields=candidate,clientContact,user,id&BhRestToken=55010e55-aa0d-4971-9418-7e27541f059e`;
                                console.log({start:start})
                                console.log({datacount:data.count})
                                callAPI(start,nextEndpoint);
                            }
                            wrongIds = postmanResponse.filter(x => {
                                if(x.clientContact === null) return;
                                return !ids.includes(x.clientContact.id)
                            })

                         }));

}
let postmanResponse = [];
let wrongIds = []
callAPI(0,`https://rest30.bullhornstaffing.com/rest-services/59klg/query/Sendout?sort=id&count=500&start=0&where=(dateAdded>=946677600000)AND(dateAdded<=1672524000000)&fields=candidate,clientContact,user,id&BhRestToken=55010e55-aa0d-4971-9418-7e27541f059e`);