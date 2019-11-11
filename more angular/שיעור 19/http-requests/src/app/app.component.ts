import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Post } from './posts.model';
import { PostsService } from './posts.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  loadedPosts = [];
  isFetching = false;

  error = null;
  constructor(private http: HttpClient, private postsService: PostsService) { }

  ngOnInit() {
    this.fetchPosts();
  }

  onCreatePost(postData: { title: string; content: string }) {
    // Send Http request
    // this.http.post<{ name: string }>('https://hackeru-a6482.firebaseio.com/posts.json', postData).subscribe(responseData => {
    //   console.log(responseData);
    // });
    this.postsService.createAndStorePost(postData.title, postData.content);
  }

  onFetchPosts() {
    // Send Http request
    this.fetchPosts();
  }

  onClearPosts() {
    // Send Http request
    this.postsService.deletePosts().subscribe(() => {
      this.loadedPosts = [];
    });
  }

  private fetchPosts() {
    this.isFetching = true;
    this.postsService.fetchPosts().subscribe(posts => {
      const postsArray: Post[] = [];
      for (const key in posts) {
        postsArray.push({ ...posts[key], id: key }) // post = {content, title} ||  {content,title}
      }
      this.loadedPosts = postsArray;
      this.isFetching = false;
    }, error => {
      this.error = error.message;
      console.log(error);
      this.isFetching = false;
    });
  }

  onHandleError() {
    this.error = null;
  }
}
