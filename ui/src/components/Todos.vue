<template>
  <div class="container">
    <h3>Todos:</h3>
    <table class="table">
      <thead>
        <tr>
          <th scope="col">Id</th>
          <th scope="col">Name</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="todo in todos" v-bind:key="todo.id"> 
          <th scope="row">{{todo.id}}</th>
          <td>{{todo.name}}</td>
        </tr>
      </tbody>
    </table> 
  </div>
</template>

<script>
  import axios from 'axios';
  export default {
    name: 'Todos',
    data() {
      return {
        todos: null,
      };
    },
    created: function() {
      axios
        .get('http://localhost:5000/api/todo')
        .then(res => {
          this.todos = res.data;
        })
    }
  }
</script>

<style scoped>
</style>
