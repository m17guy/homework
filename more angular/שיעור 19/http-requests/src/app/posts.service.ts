import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Post } from './posts.model';

@Injectable({ providedIn: 'root' })
export class PostsService {

  constructor(private http: HttpClient) { }


  createAndStorePost(title: string, content: string) {
    const postData: Post = { title: title, content: content };
    this.http.post<{ name: string }>('https://hackeru-a6482.firebaseio.com/posts.json', postData).subscribe(responseData => {
      console.log(responseData);
    });
  }

  fetchPosts() {
    let searchParams = new HttpParams();
    searchParams = searchParams.append('print', 'pretty');
    searchParams = searchParams.append('custom', 'key');
    return this.http.get<{ key: Post }>('https://hackeru-a6482.firebaseio.com/posts.json',
      {
        headers: new HttpHeaders({ 'Custom-Header': 'Hello' }),
        params: searchParams
      });
    // .subscribe(posts => {
    //   const postsArray: Post[] = [];
    //   for (const key in posts) {
    //     postsArray.push({ ...posts[key], id: key }) // post = {content, title} ||  {content,title}
    //   }
    // });
  }

  deletePosts() {
    return this.http.delete('https://hackeru-a6482.firebaseio.com/posts.json')
  }
}