namespace ExamenCsharpQ3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_heap = new System.Windows.Forms.GroupBox();
            this.gb_stack = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Heap = new System.Windows.Forms.DataGridView();
            this.dataGridView_Stack = new System.Windows.Forms.DataGridView();
            this.bt_heap_compute = new System.Windows.Forms.Button();
            this.bt_stack_compute = new System.Windows.Forms.Button();
            this.tb_heap_complexity = new System.Windows.Forms.TextBox();
            this.tb_stack_complexity = new System.Windows.Forms.TextBox();
            this.treeView_binarytree = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_tree_add = new System.Windows.Forms.Button();
            this.bt_tree_clear = new System.Windows.Forms.Button();
            this.tb_add = new System.Windows.Forms.TextBox();
            this.gb_queue = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_queue_complexity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_Queue = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_Queue_addToQueue = new System.Windows.Forms.TextBox();
            this.gb_heap.SuspendLayout();
            this.gb_stack.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Heap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stack)).BeginInit();
            this.gb_queue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Queue)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_heap
            // 
            this.gb_heap.Controls.Add(this.label1);
            this.gb_heap.Controls.Add(this.tb_heap_complexity);
            this.gb_heap.Controls.Add(this.bt_heap_compute);
            this.gb_heap.Controls.Add(this.dataGridView_Heap);
            this.gb_heap.Location = new System.Drawing.Point(48, 50);
            this.gb_heap.Name = "gb_heap";
            this.gb_heap.Size = new System.Drawing.Size(814, 328);
            this.gb_heap.TabIndex = 0;
            this.gb_heap.TabStop = false;
            this.gb_heap.Text = "Heap";
            // 
            // gb_stack
            // 
            this.gb_stack.Controls.Add(this.label2);
            this.gb_stack.Controls.Add(this.tb_stack_complexity);
            this.gb_stack.Controls.Add(this.bt_stack_compute);
            this.gb_stack.Controls.Add(this.dataGridView_Stack);
            this.gb_stack.Location = new System.Drawing.Point(48, 384);
            this.gb_stack.Name = "gb_stack";
            this.gb_stack.Size = new System.Drawing.Size(814, 315);
            this.gb_stack.TabIndex = 1;
            this.gb_stack.TabStop = false;
            this.gb_stack.Text = "Stack";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_add);
            this.groupBox3.Controls.Add(this.bt_tree_clear);
            this.groupBox3.Controls.Add(this.bt_tree_add);
            this.groupBox3.Controls.Add(this.treeView_binarytree);
            this.groupBox3.Location = new System.Drawing.Point(889, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 649);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Binary Tree";
            // 
            // dataGridView_Heap
            // 
            this.dataGridView_Heap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Heap.Location = new System.Drawing.Point(15, 49);
            this.dataGridView_Heap.Name = "dataGridView_Heap";
            this.dataGridView_Heap.RowHeadersWidth = 51;
            this.dataGridView_Heap.RowTemplate.Height = 24;
            this.dataGridView_Heap.Size = new System.Drawing.Size(793, 225);
            this.dataGridView_Heap.TabIndex = 0;
            // 
            // dataGridView_Stack
            // 
            this.dataGridView_Stack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Stack.Location = new System.Drawing.Point(11, 45);
            this.dataGridView_Stack.Name = "dataGridView_Stack";
            this.dataGridView_Stack.RowHeadersWidth = 51;
            this.dataGridView_Stack.RowTemplate.Height = 24;
            this.dataGridView_Stack.Size = new System.Drawing.Size(793, 225);
            this.dataGridView_Stack.TabIndex = 1;
            // 
            // bt_heap_compute
            // 
            this.bt_heap_compute.Location = new System.Drawing.Point(15, 280);
            this.bt_heap_compute.Name = "bt_heap_compute";
            this.bt_heap_compute.Size = new System.Drawing.Size(141, 42);
            this.bt_heap_compute.TabIndex = 1;
            this.bt_heap_compute.Text = "compute";
            this.bt_heap_compute.UseVisualStyleBackColor = true;
            // 
            // bt_stack_compute
            // 
            this.bt_stack_compute.Location = new System.Drawing.Point(15, 276);
            this.bt_stack_compute.Name = "bt_stack_compute";
            this.bt_stack_compute.Size = new System.Drawing.Size(141, 33);
            this.bt_stack_compute.TabIndex = 2;
            this.bt_stack_compute.Text = "random";
            this.bt_stack_compute.UseVisualStyleBackColor = true;
            // 
            // tb_heap_complexity
            // 
            this.tb_heap_complexity.Location = new System.Drawing.Point(704, 21);
            this.tb_heap_complexity.Name = "tb_heap_complexity";
            this.tb_heap_complexity.Size = new System.Drawing.Size(100, 22);
            this.tb_heap_complexity.TabIndex = 2;
            // 
            // tb_stack_complexity
            // 
            this.tb_stack_complexity.Location = new System.Drawing.Point(704, 17);
            this.tb_stack_complexity.Name = "tb_stack_complexity";
            this.tb_stack_complexity.Size = new System.Drawing.Size(100, 22);
            this.tb_stack_complexity.TabIndex = 3;
            // 
            // treeView_binarytree
            // 
            this.treeView_binarytree.Location = new System.Drawing.Point(6, 21);
            this.treeView_binarytree.Name = "treeView_binarytree";
            this.treeView_binarytree.Size = new System.Drawing.Size(407, 583);
            this.treeView_binarytree.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "complexity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "complexity";
            // 
            // bt_tree_add
            // 
            this.bt_tree_add.Location = new System.Drawing.Point(16, 610);
            this.bt_tree_add.Name = "bt_tree_add";
            this.bt_tree_add.Size = new System.Drawing.Size(75, 33);
            this.bt_tree_add.TabIndex = 3;
            this.bt_tree_add.Text = "add";
            this.bt_tree_add.UseVisualStyleBackColor = true;
            // 
            // bt_tree_clear
            // 
            this.bt_tree_clear.Location = new System.Drawing.Point(250, 610);
            this.bt_tree_clear.Name = "bt_tree_clear";
            this.bt_tree_clear.Size = new System.Drawing.Size(75, 33);
            this.bt_tree_clear.TabIndex = 4;
            this.bt_tree_clear.Text = "clear";
            this.bt_tree_clear.UseVisualStyleBackColor = true;
            // 
            // tb_add
            // 
            this.tb_add.Location = new System.Drawing.Point(97, 615);
            this.tb_add.Name = "tb_add";
            this.tb_add.Size = new System.Drawing.Size(147, 22);
            this.tb_add.TabIndex = 4;
            // 
            // gb_queue
            // 
            this.gb_queue.Controls.Add(this.tb_Queue_addToQueue);
            this.gb_queue.Controls.Add(this.button2);
            this.gb_queue.Controls.Add(this.label3);
            this.gb_queue.Controls.Add(this.tb_queue_complexity);
            this.gb_queue.Controls.Add(this.button1);
            this.gb_queue.Controls.Add(this.dataGridView_Queue);
            this.gb_queue.Location = new System.Drawing.Point(48, 717);
            this.gb_queue.Name = "gb_queue";
            this.gb_queue.Size = new System.Drawing.Size(814, 322);
            this.gb_queue.TabIndex = 3;
            this.gb_queue.TabStop = false;
            this.gb_queue.Text = "Queue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "complexity";
            // 
            // tb_queue_complexity
            // 
            this.tb_queue_complexity.Location = new System.Drawing.Point(704, 17);
            this.tb_queue_complexity.Name = "tb_queue_complexity";
            this.tb_queue_complexity.Size = new System.Drawing.Size(100, 22);
            this.tb_queue_complexity.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enqueue";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Queue
            // 
            this.dataGridView_Queue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Queue.Location = new System.Drawing.Point(11, 45);
            this.dataGridView_Queue.Name = "dataGridView_Queue";
            this.dataGridView_Queue.RowHeadersWidth = 51;
            this.dataGridView_Queue.RowTemplate.Height = 24;
            this.dataGridView_Queue.Size = new System.Drawing.Size(793, 225);
            this.dataGridView_Queue.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dequeue";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_Queue_addToQueue
            // 
            this.tb_Queue_addToQueue.Location = new System.Drawing.Point(325, 276);
            this.tb_Queue_addToQueue.Name = "tb_Queue_addToQueue";
            this.tb_Queue_addToQueue.Size = new System.Drawing.Size(147, 22);
            this.tb_Queue_addToQueue.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 1068);
            this.Controls.Add(this.gb_queue);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_stack);
            this.Controls.Add(this.gb_heap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_heap.ResumeLayout(false);
            this.gb_heap.PerformLayout();
            this.gb_stack.ResumeLayout(false);
            this.gb_stack.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Heap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Stack)).EndInit();
            this.gb_queue.ResumeLayout(false);
            this.gb_queue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Queue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_heap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_heap_complexity;
        private System.Windows.Forms.Button bt_heap_compute;
        private System.Windows.Forms.DataGridView dataGridView_Heap;
        private System.Windows.Forms.GroupBox gb_stack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_stack_complexity;
        private System.Windows.Forms.Button bt_stack_compute;
        private System.Windows.Forms.DataGridView dataGridView_Stack;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_add;
        private System.Windows.Forms.Button bt_tree_clear;
        private System.Windows.Forms.Button bt_tree_add;
        private System.Windows.Forms.TreeView treeView_binarytree;
        private System.Windows.Forms.GroupBox gb_queue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_queue_complexity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_Queue;
        private System.Windows.Forms.TextBox tb_Queue_addToQueue;
    }
}

